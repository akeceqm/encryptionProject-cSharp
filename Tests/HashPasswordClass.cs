using System;
using System.Security.Cryptography;
using System.Text;
namespace EncryptionProject;
public class HashPasswordClass
{
    public string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Преобразование пароля в массив байт
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            //Хэширование праоля
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            //Преобразование хэша в строку
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hashBytes)
            {
                stringBuilder.Append(b.ToString("x2"));
            }

            Console.WriteLine($"Хэшированный пароль: {stringBuilder.ToString()}");
            return stringBuilder.ToString();
        }
    }
}

