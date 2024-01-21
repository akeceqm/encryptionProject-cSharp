using static System.Net.Mime.MediaTypeNames;

namespace EncryptionProject;

public class Message
{
    public string TextMessage { get; private set; }
    public string DescryptionCode { get; private set; }

    public Message()
    {
        Console.Write("Введите сообщение: ");
        TextMessage = Console.ReadLine();

        Console.Write("Введите код для дешифрования: ");
        DescryptionCode = Console.ReadLine();
    }

    public void DisplayMessage()
    {
        Console.WriteLine(TextMessage);
    }
}

