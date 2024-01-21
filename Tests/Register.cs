using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionProject;

public class Register : HashPasswordClass
{

    public User InputUserData()
    {
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        // Хэширование пароля с использованием SHA-256
        string hashedPassword = HashPassword(password);

        User newUser = new User
        {
            Login = login,
            Password = password
        };
        return newUser;
    }
}

