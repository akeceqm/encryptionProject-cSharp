namespace EncryptionProject;

public class Register
{
    public User InputUserData()
    {
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        User newUser = new User
        {
            Login = login,
            Password = password
        };
        return newUser;
    }
}

