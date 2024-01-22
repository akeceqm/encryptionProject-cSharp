using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace EncryptionProject;

public class EncryptMessage
{
    public static byte[] Encrypt(string plainText, byte[] key, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                }
                return msEncrypt.ToArray();
            }
        }
    }
}
