using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionProject;

    public class Program
    {
    static void Main(string[] args)
    {
        Register register = new Register();

        User newUser = register.InputUserData();


        Console.ReadLine();
    }
    }
