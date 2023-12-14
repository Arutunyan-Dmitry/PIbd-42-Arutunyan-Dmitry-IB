namespace BusinessLogic
{
    public class DESofb
    {
        // Массив начальной перестановки
        private static readonly int[] IP = {
            58, 50, 42, 34, 26, 18, 10, 2,
            60, 52, 44, 36, 28, 20, 12, 4,
            62, 54, 46, 38, 30, 22, 14, 6,
            64, 56, 48, 40, 32, 24, 16, 8,
            57, 49, 41, 33, 25, 17,  9, 1,
            59, 51, 43, 35, 27, 19, 11, 3,
            61, 53, 45, 37, 29, 21, 13, 5,
            63, 55, 47, 39, 31, 23, 15, 7
        };
        // Массив конечной (обратной) перестановки
        private static readonly int[] IIP = {
            40, 8, 48, 16, 56, 24, 64, 32,
            39, 7, 47, 15, 55, 23, 63, 31,
            38, 6, 46, 14, 54, 22, 62, 30,
            37, 5, 45, 13, 53, 21, 61, 29,
            36, 4, 44, 12, 52, 20, 60, 28,
            35, 3, 43, 11, 51, 19, 59, 27,
            34, 2, 42, 10, 50, 18, 58, 26,
            33, 1, 41,  9, 49, 17, 57, 25
        };
        // Массив перестановки расширения
        private static readonly int[] E = {
            32,  1,  2,  3,  4,  5,
            4,  5,  6,  7,  8,  9,
            8,  9, 10, 11, 12, 13,
            12, 13, 14, 15, 16, 17,
            16, 17, 18, 19, 20, 21,
            20, 21, 22, 23, 24, 25,
            24, 25, 26, 27, 28, 29,
            28, 29, 30, 31, 32,  1
        };
        // Массив перестановки Р
        private static readonly int[] P = {
            16,  7, 20, 21,
            29, 12, 28, 17,
            1, 15, 23, 26,
            5, 18, 31, 10,
            2,  8, 24, 14,
            32, 27,  3,  9,
            19, 13, 30,  6,
            22, 11,  4, 25
        };
        // Массивы S-блоков
        private static readonly int[] S1 = {
            14,  4, 13,  1,  2, 15, 11,  8,  3, 10,  6, 12,  5,  9,  0,  7,
             0, 15,  7,  4, 14,  2, 13,  1, 10,  6, 12, 11,  9,  5,  3,  8,
             4,  1, 14,  8, 13,  6,  2, 11, 15, 12,  9,  7,  3, 10,  5,  0,
            15, 12,  8,  2,  4,  9,  1,  7,  5, 11,  3, 14, 10,  0,  6, 13
        };
        private static readonly int[] S2 = {
            15,  1,  8, 14,  6, 11,  3,  4,  9,  7,  2, 13, 12,  0,  5, 10,
             3, 13,  4,  7, 15,  2,  8, 14, 12,  0,  1, 10,  6,  9, 11,  5,
             0, 14,  7, 11, 10,  4, 13,  1,  5,  8, 12,  6,  9,  3,  2, 15,
            13,  8, 10,  1,  3, 15,  4,  2, 11,  6,  7, 12,  0,  5, 14,  9
        };
        private static readonly int[] S3 = {
            10,  0,  9, 14,  6,  3, 15,  5,  1, 13, 12,  7, 11,  4,  2,  8,
            13,  7,  0,  9,  3,  4,  6, 10,  2,  8,  5, 14, 12, 11, 15,  1,
            13,  6,  4,  9,  8, 15,  3,  0, 11,  1,  2, 12,  5, 10, 14,  7,
             1, 10, 13,  0,  6,  9,  8,  7,  4, 15, 14,  3, 11,  5,  2, 12
        };
        private static readonly int[] S4 = {
             7, 13, 14,  3,  0,  6,  9, 10,  1,  2,  8,  5, 11, 12,  4, 15,
            13,  8, 11,  5,  6, 15,  0,  3,  4,  7,  2, 12,  1, 10, 14,  9,
            10,  6,  9,  0, 12, 11,  7, 13, 15,  1,  3, 14,  5,  2,  8,  4,
             3, 15,  0,  6, 10,  1, 13,  8,  9,  4,  5, 11, 12,  7,  2, 14
        };
        private static readonly int[] S5 = {
             2, 12,  4,  1,  7, 10, 11,  6,  8,  5,  3, 15, 13,  0, 14,  9,
            14, 11,  2, 12,  4,  7, 13,  1,  5,  0, 15, 10,  3,  9,  8,  6,
             4,  2,  1, 11, 10, 13,  7,  8, 15,  9, 12,  5,  6,  3,  0, 14,
            11,  8, 12,  7,  1, 14,  2, 13,  6, 15,  0,  9, 10,  4,  5,  3
        };
        private static readonly int[] S6 = {
            12,  1, 10, 15,  9,  2,  6,  8,  0, 13,  3,  4, 14,  7,  5, 11,
            10, 15,  4,  2,  7, 12,  9,  5,  6,  1, 13, 14,  0, 11,  3,  8,
             9, 14, 15,  5,  2,  8, 12,  3,  7,  0,  4, 10,  1, 13, 11,  6,
             4,  3,  2, 12,  9,  5, 15, 10, 11, 14,  1,  7,  6,  0,  8, 13
        };
        private static readonly int[] S7 = {
             4, 11,  2, 14, 15,  0,  8, 13,  3, 12,  9,  7,  5, 10,  6,  1,
            13,  0, 11,  7,  4,  9,  1, 10, 14,  3,  5, 12,  2, 15,  8,  6,
             1,  4, 11, 13, 12,  3,  7, 14, 10, 15,  6,  8,  0,  5,  9,  2,
             6, 11, 13,  8,  1,  4, 10,  7,  9,  5,  0, 15, 14,  2,  3, 12
        };
        private static readonly int[] S8 = {
            13,  2,  8,  4,  6, 15, 11,  1, 10,  9,  3, 14,  5,  0, 12,  7,
             1, 15, 13,  8, 10,  3,  7,  4, 12,  5,  6, 11,  0, 14,  9,  2,
             7, 11,  4,  1,  9, 12, 14,  2,  0,  6, 10, 13, 15,  3,  5,  8,
             2,  1, 14,  7,  4, 10,  8, 13, 15, 12,  9,  0,  3,  5,  6, 11
        };
        // Начальный массив перестановки для ключа
        private static readonly int[] PC1 = {
            57, 49, 41, 33, 25, 17,  9,
             1, 58, 50, 42, 34, 26, 18,
            10,  2, 59, 51, 43, 35, 27,
            19, 11,  3, 60, 52, 44, 36,
            63, 55, 47, 39, 31, 23, 15,
             7, 62, 54, 46, 38, 30, 22,
            14,  6, 61, 53, 45, 37, 29,
            21, 13,  5, 28, 20, 12,  4
        };
        // Конечный массив перестановки для ключа
        private static readonly int[] PC2 = {
            14, 17, 11, 24,  1,  5,
             3, 28, 15,  6, 21, 10,
            23, 19, 12,  4, 26,  8,
            16,  7, 27, 20, 13,  2,
            41, 52, 31, 37, 47, 55,
            30, 40, 51, 45, 33, 48,
            44, 49, 39, 56, 34, 53,
            46, 42, 50, 36, 29, 32
        };
        // Массив кол-ва бит побитового сдвига влево половины ключа для каждой итерации алгоритма
        private static readonly int[] SHIFTS = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };
        // Функция исключающего или для каждого элемента массива байт
        private byte[] XOR(byte[] one, byte[] two)
        {
            byte[] result = new byte[one.Length];
            for (int i = 0; i < one.Length; i++)
            {
                result[i] = (byte)(one[i] ^ two[i]);
            }
            return result;
        }
        // Функция перестановки бит по массиву перестановок
        private byte[] Permute(byte[] input, int[] mapping)
        {
            int byteCount = 1 + (mapping.Length - 1) / 8;
            byte[] output = new byte[byteCount];
            int pos;
            // В соответствии со значением в массиве перестановок,
            // значение под данным индексом изначального массива
            // последовательно помещается в результирующий массив
            for (int i = 0; i < mapping.Length; i++)
            {
                pos = mapping[i] - 1;
                int value = GetBitFromArray(input, pos);
                SetBitInArray(output, i, value);
            }
            return output;
        }
        // Функция получения бита из массива
        private int GetBitFromArray(byte[] array, int pos)
        {
            int value;
            int bytePos = pos / 8;
            int bitPos = pos % 8;
            value = (array[bytePos] >> (8 - (bitPos + 1))) & 0x0001;
            return value;
        }
        // Функция добавления бита в массив 
        private void SetBitInArray(byte[] input, int pos, int value)
        {
            int bytePos = pos / 8;
            int bitPos = pos % 8;
            byte old = input[bytePos];
            old = (byte)((0xFF7F >> bitPos) & old & 0x00FF);
            byte newByte = (byte)((value << (8 - (bitPos + 1))) | old);
            input[bytePos] = newByte;
        }
        // Функция конвертации hex строки в байт массив
        private byte[] HexStringToByteArray(string text)
        {
            int length = text.Length;
            int n = (int)Math.Ceiling((length + 1) / 2.0);
            byte[] result = new byte[n];
            for (int i = length - 1; i >= 0; i -= 2)
            {
                if (i == 0)
                {
                    result[i / 2] = (byte)((('0') << 4) + text[i]);
                }
                else
                {
                    result[i / 2] = (byte)((text[i-1] << 4) + text[i]);
                }
            }
            return result;
        }
        private byte[] GetBits(byte[] input, int startPos, int length)
        {
            int noOfBytes = (length - 1) / 8 + 1;
            byte[] output = new byte[noOfBytes];
            for (int i = 0; i < length; i++)
            {
                int value = GetBitFromArray(input, startPos + i);
                SetBitInArray(output, i, value);
            }
            return output;
        }
        // Функция побитового сдвига влево на определённое кол-во бит
        private byte[] RotateLeft(byte[] input, int step, int length)
        {
            int noOfBytes = (length - 1) / 8 + 1;
            byte[] output = new byte[noOfBytes];
            for (int i = 0; i < length; i++)
            {
                int value = GetBitFromArray(input, (i + step) % length);
                SetBitInArray(output, i, value);
            }
            return output;
        }
        // Функция контактенации двух байтовых массивов
        private byte[] ConcatBits(byte[] one, int oneLength,
          byte[] two, int twoLength)
        {
            int noOfBytes = (oneLength + twoLength - 1) / 8 + 1;
            byte[] output = new byte[noOfBytes];
            int i = 0, j = 0;
            for (; i < oneLength; i++)
            {
                int value = GetBitFromArray(one, i);
                SetBitInArray(output, j, value);
                j++;
            }
            for (i = 0; i < twoLength; i++)
            {
                int value = GetBitFromArray(two, i);
                SetBitInArray(output, j, value);
                j++;
            }
            return output;
        }
        // Функция получения подключей для каждой из 16 итераций функции Фестеля
        private byte[][] GetSubKeys(byte[] masterKey)
        {
            // Получение массива сдвигов
            int noOfSubKeys = SHIFTS.Length;
            // Получения массива первичной перестановки PC
            int keySize = PC1.Length;
            // Первичная перестановка исходного ключа
            byte[] key = Permute(masterKey, PC1);
            byte[][] subKeys = new byte[noOfSubKeys][];
            for (int i = 0; i < noOfSubKeys; i++)
            {
                subKeys[i] = new byte[keySize];
            }
            // Разделение ключа на левую и правую половины
            byte[] leftHalf = GetBits(key, 0, keySize / 2);
            byte[] rightHalf = GetBits(key, keySize / 2, keySize / 2);
            for (int i = 0; i < noOfSubKeys; i++)
            {
                // Побитовый сдвиг половин ключа влево на определённое количесвто бит
                leftHalf = RotateLeft(leftHalf, SHIFTS[i], keySize / 2);
                rightHalf = RotateLeft(rightHalf, SHIFTS[i], keySize / 2);
                // Контактенация левой и правой половины ключей
                byte[] subKey = ConcatBits(leftHalf, keySize / 2, rightHalf, keySize / 2);
                // Вторичная перестановка значения ключа данного уровня
                subKeys[i] = Permute(subKey, PC2);
            }
            return subKeys;
        }
        // Функция шифрования / расшифрования алгоритмом DES в режиме OFB
        public byte[] Crypt(byte[] message, byte[] key)
        {
            // проверка длины ключа и сообщения
            if (message.Length < 8)
            {
                throw new ArgumentException("Сообщение должно быть длинной не менне 64 бит");
            }
            if (key.Length != 8)
            {
                throw new ArgumentException("Ключ должно быть длинной 64 бит");
            }
            // Выделение кол-ва блоков по 64 бит из сообщения
            int length = message.Length;
            int n = (length + 7) / 8 * 8;
            // Инициализация результирующего массива шифра
            byte[] cipher = new byte[n];
            // Если размер сообщения равен размеру блока в 64 бит, то происходит процесс шифрования
            if (length == 8)
            {
                // Получение инициализирующего вектора (нонса)
                byte[] nounce = GetNounce();
                // Функция генерации блока псевдосучайных 8 байт
                byte[] temp = CryptText(nounce, key);
                // Комбинация псевдослучайных байтов с открытым сообщением методом побитового исключающего ИЛИ
                byte[] result = XORBytes(temp, message);
                return result;
            }
            // Если длина сообщения больше 64 бит, процесс шифрования происходит поблочно
            int i = 0;
            int k = 0;
            // Получение инициализирующего вектора (нонса)
            byte[] feedback = GetNounce();
            while (i < length)
            {
                // Выделение 64-битного блока сообщения
                byte[] block = new byte[8];
                byte[] result;
                int j = 0;
                for (; j < 8 && i < length; j++, i++)
                {
                    block[j] = message[i];
                }
                while (j < 8)
                {
                    // Заполнение пустыми значениями до конца блока
                    block[j++] = 0x20;
                }
                // Функция генерации блока псевдосучайных 8 байт
                result = CryptText(feedback, key);
                // Наполнение нового вектора инициализаций псевдослучайными значениями
                feedback = result.Take(8).ToArray();
                // Комбинация псевдослучайных байтов с открытым блоком сообщения методом побитового исключающего ИЛИ
                result = XORBytes(result, block);
                // Наполнение результируюшего массива шифром блока
                for (j = 0; j < 8 && k < cipher.Length; j++, k++)
                {
                    cipher[k] = result[j];
                }
            }
            return cipher;
        }
        // Функция, возвращающая инициализирующий вектор
        private byte[] GetNounce()
        {
            // В програмных решениях вектор инициализации задаётся случайно, 
            // но в данном случае задаим его статичным значением
            return HexStringToByteArray("DCBE6AE7EA5D5C61");
        }
        // Функция генерации блока псевдосучайных байт
        public byte[] CryptText(byte[] message, byte[] key)
        {
            byte[] result;
            int blockSize = IP.Length;
            // Получение подключей
            byte[][] subKeys = GetSubKeys(key);
            int noOfRounds = subKeys.Length;
            // Начальная перестановка IP
            message = Permute(message, IP);
            // Разделение вектора инициализации на правую и левую половины
            byte[] leftHalf = GetBits(message, 0, blockSize / 2);
            byte[] rightHalf = GetBits(message, blockSize / 2, blockSize / 2);
            // Основная функция шифрования (функция Фестеля) 
            for (int i = 0; i < noOfRounds; i++)
            {
                byte[] temp = rightHalf;
                // Расширение 32-битного вектора правой части вектора инициализации 
                // до 48-битного значения матрицей перестановок E
                rightHalf = Permute(rightHalf, E);
                // Применение функции исключающего ИЛИ для каждого из элементов
                // правой половины вектора и подключа данной итерации
                byte[] roundKey = subKeys[i];
                rightHalf = XOR(rightHalf, roundKey);
                // Применение функции S преобразований для правой половины вектора инициализации
                rightHalf = SBox(rightHalf);
                // Перестановка P
                rightHalf = Permute(rightHalf, P);
                // Побитовое исключающее ИЛИ для левой и правой половин вектора инициализации
                rightHalf = XOR(rightHalf, leftHalf);
                // Обновление значения левой части инициализирующего вектора
                leftHalf = temp;
            }
            // Контактенация частей вектора инициализаций, обработанных функцией Фестеля
            byte[] concatHalves = ConcatBits(rightHalf, blockSize / 2, leftHalf, blockSize / 2);
            // Конечная (обратная) перестановка IIP
            result = Permute(concatHalves, IIP);
            return result;
        }
        // Метод побитового исключающего ИЛИ с маской для правильного представления байта
        public static byte[] XORBytes(byte[] in1, byte[] in2)
        {
            byte[] result = new byte[in1.Length];
            for (int i = 0; i < in1.Length; i++)
            {
                result[i] = (byte)((in1[i] ^ in2[i]) & 0xff);
            }
            return result;
        }
        // Функция S преобразований 
        private byte[] SBox(byte[] input)
        {
            // Разбиение вектора на блоки по 6 бит
            input = Split(input, 6);
            byte[] output = new byte[input.Length / 2];
            int leftHalf = 0;
            // Для каждого блока вектора
            for (int i = 0; i < input.Length; i++)
            {
                byte block = input[i];
                // Вычисление позиции элемента S-блока: 
                // Строка - 1й И последний бит блока вектора
                // Столбец - серединный бит (4й) блока вектора
                int row = 2 * (block >> 7 & 0x0001) + (block >> 2 & 0x0001);
                int col = block >> 3 & 0x000F;
                // Выбор S-блока текушей итерации
                int[] selectedSBox = GetSBox(i);
                // Назначение правой половине значения выбранного элемента S-блока
                int rightHalf = selectedSBox[16 * row + col];
                if (i % 2 == 0)
                {
                    // На чётной итерации приравнивание значения 
                    // левой половины к правой
                    leftHalf = rightHalf;
                }
                else
                {
                    // На нечётной операции занесение значения объединения половин 
                    // в байт в новую правую половину вектора инициализации
                    output[i / 2] = (byte)(16 * leftHalf + rightHalf);
                    leftHalf = 0;
                }
            }
            return output;
        }
        // Функция получения S-блока для текущей итерации функции S преобразований
        private int[] GetSBox(int i)
        {
            switch (i)
            {
                case 0: return S1;
                case 1: return S2;
                case 2: return S3;
                case 3: return S4;
                case 4: return S5;
                case 5: return S6;
                case 6: return S7;
                case 7: return S8;
                default: return null;
            }
        }
        // Функция разделения массива байт на указанное значение
        private byte[] Split(byte[] input, int length)
        {
            int noOfBytes = (8 * input.Length - 1) / length + 1;
            byte[] output = new byte[noOfBytes];
            for (int i = 0; i < noOfBytes; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    int value = GetBitFromArray(input, length * i + j);
                    SetBitInArray(output, 8 * i + j, value);
                }
            }
            return output;
        }
    }
}
