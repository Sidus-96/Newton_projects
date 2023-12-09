using System.IO;
using System.Security.Cryptography;

namespace GreenThumb.Manager
{
    internal class KeyManager
    {
        public static string GetEncryptionkey()
        {
            string key;
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Key.txt");
            bool fileExist = File.Exists(path);
            if (fileExist)
            {
                key = File.ReadAllText(path);  //Läser all text i en fil, sökväg

            }
            else
            {
                key = GenerateEncryptionKey();
                File.WriteAllText(path, key);

            }
            return key;
        }

        public static string GenerateEncryptionKey()
        {
            var rng = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            rng.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray);
        }
    }
}
