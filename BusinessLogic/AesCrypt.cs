using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Banking.BusinessLogic
{
    class AesCrypt
    {
        private PasswordDeriveBytes passBytes;
        private byte[] Key;
        private byte[] IV;

        public AesCrypt()
        {
            passBytes = new PasswordDeriveBytes("1254fhgffh6543", Encoding.Default.GetBytes("dfgsdg2432534"));
            Key = passBytes.GetBytes(32);
            IV = passBytes.GetBytes(16);
        }

        public string EncryptAes(string plainText)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key
                    , aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt
                        , encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(
                            csEncrypt))
                        {

                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return System.Text.Encoding.Default.GetString(encrypted);
        }

        public string DecryptAes(string cipherText)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key
                    , aesAlg.IV);
                byte[] text = Encoding.Default.GetBytes(cipherText);

                using (MemoryStream msDecrypt = new MemoryStream(text))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt
                        , decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}
