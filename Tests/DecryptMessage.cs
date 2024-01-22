using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace EncryptionProject;

public class DecryptMessage
{
    public static string Descrypt(byte[] encryptedText, byte[] key, byte[] iv)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = key;
            aesAlg.IV = iv;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(encryptedText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (MemoryStream msPlain = new MemoryStream())
                    {
                        byte[] buffer = new byte[4096];
                        int bytesRead;

                        while ((bytesRead = csDecrypt.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            msPlain.Write(buffer, 0, bytesRead);
                        }

                        return Encoding.UTF8.GetString(msPlain.ToArray());
                    }
                }
            }
        }
    }
}




