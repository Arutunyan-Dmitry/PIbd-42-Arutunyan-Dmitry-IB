using FileImplement.Models;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

namespace FileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string UsertFileName = Path.GetTempFileName();
        private readonly string ProtectedUsertFileName = "User.xml";
        private readonly string KeyFile = "keyfile.txt";
        public List<User> Users { get; set; }

        private FileDataListSingleton()
        {
            Users = LoadUsers();
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        public static void SaveFileDataListSingleton()
        {
            instance.SaveUsers();
        }

        public static void GetFileDataListSingleton()
        {
            instance = GetInstance();
            instance.GetFile();
            instance.Users = instance.LoadUsers();
        }
        private void GetFile()
        {
            if (File.Exists(ProtectedUsertFileName))
            {
                DecryptFile();
                XmlDocument sourceXmlDocument = new XmlDocument();
                sourceXmlDocument.Load(ProtectedUsertFileName);
                XmlDocument targetXmlDocument = new XmlDocument();
                XmlNode importedNode = targetXmlDocument.ImportNode(sourceXmlDocument.DocumentElement, true);
                targetXmlDocument.AppendChild(importedNode);
                targetXmlDocument.Save(UsertFileName);
                EncryptFile();
            }
            else
            {
                var xElement = new XElement("Users");
                xElement.Add(new XElement("User",
                        new XAttribute("Id", 0),
                        new XElement("Name", "ADMIN"),
                        new XElement("Password", ""),
                        new XElement("PasswordLength", 0),
                        new XElement("PasswordLifetime", 0),
                        new XElement("isDisabled", false),
                        new XElement("isLettersRequired", true),
                        new XElement("isSymbolsRequired", true),
                        new XElement("isAryphmsRequired", true),
                        new XElement("inUsage", DateTime.Now)
                ));
                var xDocument = new XDocument(xElement);
                xDocument.Save(ProtectedUsertFileName);
                EncryptFile();
                GetFile();
            }
        }

        private List<User> LoadUsers()
        {
            var list = new List<User>();
            if (new FileInfo(UsertFileName).Length > 0)
            {
                var xDocument = XDocument.Load(UsertFileName);
                var xElements = xDocument.Root.Elements("User").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new User
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        Name = elem.Element("Name").Value,
                        Password = elem.Element("Password").Value,
                        PasswordLength = Convert.ToInt32(elem.Element("PasswordLength").Value),
                        PasswordLifetime = Convert.ToInt32(elem.Element("PasswordLifetime").Value),
                        isDisabled = Convert.ToBoolean(elem.Element("isDisabled").Value),
                        isLettersRequired = Convert.ToBoolean(elem.Element("isLettersRequired").Value),
                        isSymbolsRequired = Convert.ToBoolean(elem.Element("isSymbolsRequired").Value),
                        isAryphmsRequired = Convert.ToBoolean(elem.Element("isAryphmsRequired").Value),
                        inUsage = Convert.ToDateTime(elem.Element("inUsage").Value)
                    });
                }
            }
            return list;
        }
        private void SaveUsers()
        {
            if (Users != null)
            {
                var xElement = new XElement("Users");
                foreach (var user in Users)
                {
                    xElement.Add(new XElement("User",
                        new XAttribute("Id", user.Id),
                        new XElement("Name", user.Name),
                        new XElement("Password", user.Password),
                        new XElement("PasswordLength", user.PasswordLength),
                        new XElement("PasswordLifetime", user.PasswordLifetime),
                        new XElement("isDisabled", user.isDisabled),
                        new XElement("isLettersRequired", user.isLettersRequired),
                        new XElement("isSymbolsRequired", user.isSymbolsRequired),
                        new XElement("isAryphmsRequired", user.isAryphmsRequired),
                        new XElement("inUsage", user.inUsage)
                    ));
                }
                var xDocument = new XDocument(xElement);
                xDocument.Save(UsertFileName);
                XmlDocument sourceXmlDocument = new XmlDocument();
                sourceXmlDocument.Load(UsertFileName);
                XmlDocument targetXmlDocument = new XmlDocument();
                XmlNode importedNode = targetXmlDocument.ImportNode(sourceXmlDocument.DocumentElement, true);
                targetXmlDocument.AppendChild(importedNode);
                File.Delete(ProtectedUsertFileName);
                targetXmlDocument.Save(ProtectedUsertFileName);
                File.Delete(UsertFileName);
                EncryptFile();
            }
        }

        private void EncryptFile()
        {
            if (File.Exists(KeyFile))
            {
                var key = File.ReadLines(KeyFile);
                DesEngine desEngine = new DesEngine();
                // Создание параметров ключа
                var keyParam = new KeyParameter(Convert.FromBase64String(key.ToList()[0]));
                // Создание объекта шифрования DES в режиме OFB
                IBlockCipher desCipher = new OfbBlockCipher(desEngine, 8);
                // Создание объекта шифрования с использованием ключа и режима
                var cipher = new BufferedBlockCipher(desCipher);
                cipher.Init(true, keyParam); // Инициализация шифрования
                string tmpName = Path.GetTempFileName();
                byte[] fileBytes;
                using (FileStream sourceStream = File.OpenRead(ProtectedUsertFileName))
                {
                    fileBytes = new byte[sourceStream.Length];
                    sourceStream.Read(fileBytes, 0, (int)sourceStream.Length);
                }
                File.WriteAllBytes(tmpName, fileBytes);
                File.Delete(ProtectedUsertFileName);
                using (var inputFileStream = new FileStream(tmpName, FileMode.Open))
                using (var encryptedFileStream = new FileStream(ProtectedUsertFileName, FileMode.Create))
                {
                    byte[] inputBuffer = new byte[cipher.GetBlockSize()];
                    byte[] outputBuffer = new byte[cipher.GetOutputSize(inputBuffer.Length)];
                    int bytesRead;
                    while ((bytesRead = inputFileStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                    {
                        int bytesProcessed = cipher.ProcessBytes(inputBuffer, 0, bytesRead, outputBuffer, 0);
                        encryptedFileStream.Write(outputBuffer, 0, bytesProcessed);
                    }
                    int bytesFinal = cipher.DoFinal(outputBuffer, 0);
                    encryptedFileStream.Write(outputBuffer, 0, bytesFinal);
                }
                File.Delete(tmpName);
            }
            else
            {
                using (FileStream fs = new FileStream(KeyFile, FileMode.Create, FileAccess.Write))
                {
                    FileInfo fileInfo = new FileInfo(KeyFile);
                    FileSecurity fileSecurity = fileInfo.GetAccessControl();
                    fileSecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.Read, AccessControlType.Allow));
                    fileInfo.SetAccessControl(fileSecurity);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(Convert.ToBase64String(GenerateRandomBytes(32)));
                    }
                }
                EncryptFile();
            }
        }
        private void DecryptFile()
        {
            var key = File.ReadLines(KeyFile);
            DesEngine desEngine = new DesEngine();
            // Создание параметров ключа
            var keyParam = new KeyParameter(Convert.FromBase64String(key.ToList()[0]));
            // Создание объекта шифрования DES в режиме OFB
            IBlockCipher desCipher = new OfbBlockCipher(desEngine, 8);
            // Создание объекта шифрования с использованием ключа и режима
            var cipher = new BufferedBlockCipher(desCipher);
            cipher.Init(true, keyParam); // Инициализация шифрования
            string tmpName = Path.GetTempFileName();
            byte[] fileBytes;
            using (FileStream sourceStream = File.OpenRead(ProtectedUsertFileName))
            {
                fileBytes = new byte[sourceStream.Length];
                sourceStream.Read(fileBytes, 0, (int)sourceStream.Length);
            }
            File.WriteAllBytes(tmpName, fileBytes);
            File.Delete(ProtectedUsertFileName);
            using (var encryptedFileStream = new FileStream(tmpName, FileMode.Open))
            using (var decryptedFileStream = new FileStream(ProtectedUsertFileName, FileMode.Create))
            {
                byte[] inputBuffer = new byte[cipher.GetBlockSize()];
                byte[] outputBuffer = new byte[cipher.GetOutputSize(inputBuffer.Length)];
                int bytesRead;
                while ((bytesRead = encryptedFileStream.Read(inputBuffer, 0, inputBuffer.Length)) > 0)
                {
                    int bytesProcessed = cipher.ProcessBytes(inputBuffer, 0, bytesRead, outputBuffer, 0);
                    decryptedFileStream.Write(outputBuffer, 0, bytesProcessed);
                }
                int bytesFinal = cipher.DoFinal(outputBuffer, 0);
                decryptedFileStream.Write(outputBuffer, 0, bytesFinal);
            }
            File.Delete(tmpName);
        }

        static byte[] GenerateRandomBytes(int length)
        {
            byte[] randomBytes = new byte[length];
            using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
