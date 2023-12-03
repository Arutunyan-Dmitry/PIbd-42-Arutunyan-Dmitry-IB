namespace BusinessLogic
{
    public static class SHA1
    {
        // Инициализация начальных значений (инициализационных векторов) 
        static uint h0 = 0x67452301;
        static uint h1 = 0xefcdab89;
        static uint h2 = 0x98badcfe;
        static uint h3 = 0x10325476;
        static uint h4 = 0xc3d2e1f0;

        static byte[][] blocks;

        // Метод разделения байт кода сообщения на блоки по 512 бит в каждом
        static void ParsingMessage(byte[] message)
        {
            // сколько в сообщении блоков по 512 бит с запасом.
            int iter = (int)Math.Ceiling((double)message.Length / 64);
            // сколько свободных бит остаётся в последнем 512-ти битном блоке
            int freebytes = iter * 64 - message.Length;
            // проверка, что в последнем блоке сообщения хватает свободных бит для
            // записи 1 и его длины в big-endian формате (8 баит)
            if (freebytes >= 9)
            {
                blocks = new byte[iter][];
            }
            else
            {
                throw new NotImplementedException();
            }
            // разбиение сообщения на блоки
            for (int ind = 0; ind < iter; ind++)
            {
                // создание пустого блока на 64 байта (64 * 8 = 512 бит)
                blocks[ind] = new byte[64];
                // проверка на нахждение в последнем блоке сообщения
                if (ind + 1 == iter && message.Length % 64 != 0)
                {
                    // запись хвоста сообшения в последний блок
                    for (int i = 0; i < blocks[ind].Length - freebytes; i++)
                    {
                        blocks[ind][i] = message[i + ind * 64];
                    }
                    //Добавление одного бита в конец последнего блока
                    blocks[ind][blocks[ind].Length - freebytes] = (byte)1 << 7;

                    // получение длины сообщения в big-endian формате (64 байта)
                    byte[] length = LongToByteArray((long)message.Length * 8);
                    
                    // запись длины сообщения в конец последнего 512ти битного блока
                    // (всё, что находится между единицей и последними 64 битами остаётся нулями)
                    for (int i = 0; i < length.Length; i++)
                    {
                        blocks[ind][blocks[ind].Length - length.Length + i] = length[i];
                    }
                    break;
                }
                // заполнение 512ти битного блока (не последнего) сообщения его битами
                for (int i = 0; i < blocks[ind].Length; i++)
                {
                    blocks[ind][i] = message[i + ind * 64];
                }
            }
        }
        // Функция возвращения константы K для каждого tго слова из 80
        static uint K(int t)
        {
            if (t >= 0 && t <= 19)
                return 0x5a827999;

            if (t >= 20 && t <= 39)
                return 0x6ed9eba1;

            if (t >= 40 && t <= 59)
                return 0x8f1bbcdc;

            if (t >= 60 && t <= 79)
                return 0xca62c1d6;

            throw new Exception();
        }
        // набор нелинейных операций F для tго слова из 80
        static uint f(uint x, uint y, uint z, int t)
        {
            if (t >= 0 && t <= 19)
                // исключающее или логического умножения 1й переменной на 2ю и 
                // логического умножения отрицания 1й переменной на 3ю
                return (x & y) ^ (~x & z);

            if (t >= 20 && t <= 39)
                // исключающее или 3й переменной и исключающего или 1й и 2й переменной 
                return x ^ y ^ z;

            if (t >= 40 && t <= 59)
                // исключающее или последовательного логического умножения всех переменных друг на друга
                return (x & y) ^ (x & z) ^ (y & z);

            if (t >= 60 && t <= 79)
                // исключающее или 3й переменной и исключающего или 1й и 2й переменной
                return x ^ y ^ z;

            throw new Exception();
        }
        // Метод циклического сдвига влево (на указанное кол-во бит)
        public static uint ROTL(uint original, int bits)
        {
            return (original << bits) | (original >> (32 - bits));
        }
        // Мктод генерации хеш-кода
        public static byte[] Generate(byte[] message)
        {
            // разделение сообщения на блоки по 512 бит 
            ParsingMessage(message);
            // проход по всем блокам сообщения
            for (int i = 0; i < blocks.Length; i++)
            {
                // инициализация массива W для хранения 80 32-битных слов
                uint[] W = new uint[80];
                // заполнение массива 80ю словами
                for (int t = 0; t < W.Length; t++)
                {
                    // выделение первых 16 слов по 32 бита
                    if (t <= 15)
                    {
                        byte[] word = new byte[4];
                        for (int ind = 0; ind < word.Length; ind++)
                        {
                            // запись 4-х последовательных байтов текущего блока в слово
                            word[ind] = blocks[i][ind + t * 4];
                        }
                        // запись слова в массив слов в 32-х битном формате
                        W[t] = ByteArrayToUInt(word);
                    }
                    // дополнение 16 32-битных слов до 80
                    else
                    {
                        // новое слово - это t-3е слово исключающее или t-8е слово исключающее или
                        // t-14е слово исключающее или t-16е слово с циклическим битовым сдвигом влево на 1 бит
                        W[t] = ROTL(W[t - 3] ^ W[t - 8] ^ W[t - 14] ^ W[t - 16], 1);
                    }
                }
                // инициализация хеш-значений текущего блока
                uint a = h0;
                uint b = h1;
                uint c = h2;
                uint d = h3;
                uint e = h4;
                // прохождение по всем 80 словам (основной цикл)
                for (int t = 0; t < 80; t++)
                {
                    // вычисление нового значения 1й хеш-переменной как:
                    // циклический битовый сдвиг исходного её значения влево на 5 бит + 
                    // результат нелинейной операции F + исходное значение 5й хеш-переменной +
                    // значение константы K + код слова
                    uint T = ROTL(a, 5) + f(b, c, d, t) + e + K(t) + W[t];
                    // вычисление нового значения 5й хеш-переменной как:
                    // значение 4й хеш-переменной
                    e = d;
                    // вычисление нового значения 4й хеш-переменной как:
                    // значение 3й хеш-переменной
                    d = c;
                    // вычисление нового значения 3й хеш-переменной как:
                    // циклический битовый сдвиг исходного значения 2й хеш-переменной влево на 30 бит
                    c = ROTL(b, 30);
                    // вычисление нового значения 2й хеш-переменной как:
                    // исходное значение 1й хеш-переменной
                    b = a;
                    // присвоение 1й хеш-переменной нового значения
                    a = T;
                }
                // Добавляем хеш-значение текущего блока к результату
                h0 += a;
                h1 += b;
                h2 += c;
                h3 += d;
                h4 += e;
            }
            // Конвертация итогового хеш-кода из 5 32х битных строк в массив байт
            return UIntArrayToByteArray(new uint[] { h0, h1, h2, h3, h4 });
        }

        //------------------------------------ конвертеры -------------------------------------

        // конвертация массива 32х битных значений в массив байт
        public static byte[] UIntArrayToByteArray(uint[] words)
        {
            byte[] result = new byte[words.Length * 4];

            for (int a = 0; a < words.Length; a++)
            {
                byte[] word = BitConverter.GetBytes(words[a]);
                Array.Reverse(word);

                for (int b = 0; b < 4; b++)
                {
                    result[b + a * 4] = word[b];
                }
            }

            return result;
        }
        // конвертация массива 4 байтов (32 бит) в формат uint
        public static uint ByteArrayToUInt(byte[] bytes)
        {
            // последовательная запись каждого байта массива в 32 битный формат 
            return ((uint)bytes[0] << 24) | ((uint)bytes[1] << 16) | ((uint)bytes[2] << 8) | ((uint)bytes[3]);
        }
        // конвертация 64х битного значения в массив байт
        public static byte[] LongToByteArray(long l)
        {
            byte[] array = BitConverter.GetBytes(l);
            Array.Reverse(array);
            return array;
        }
    }
}
