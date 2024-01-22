using static System.Net.Mime.MediaTypeNames;
using EncryptionProject;
using System.Text;
using System.Security.Cryptography;

namespace EncryptionProject;

public class Message
{
    public string TextMessage { get; private set; }

    private byte[] encryptionKey;
    private byte[] encryptionIV;
    private byte[] encryptedText;

    public void DisplayMessage()
    {
        Console.WriteLine(TextMessage);
    }

    public void EncryptMessage()
    {
        Console.Write("Введите сообщение: ");
        TextMessage = Console.ReadLine();

        encryptionKey = GenerateRandomBytes(16);
        encryptionIV = GenerateRandomBytes(16);
        encryptedText = EncryptionProject.EncryptMessage.Encrypt(TextMessage, encryptionKey, encryptionIV);

        Console.WriteLine($"Зашифрованный текст: {Convert.ToBase64String(encryptedText)}");
    }

    private byte[] GenerateRandomBytes(int length)
    {
        byte[] randomBytes = new byte[length];
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(randomBytes);
        }
        return randomBytes;
    }

    public void DecryptorMessage()
    {
        string decryptedText = DecryptMessage.Descrypt(encryptedText, encryptionKey, encryptionIV);
        Console.WriteLine($"Дешифрованный текст: {decryptedText}");
    }

    
}

