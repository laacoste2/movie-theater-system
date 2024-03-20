using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterSystem
{
    internal class Credentials
    {
        public const string Login = "admin";                       //Nome começando em maiusculo por convenção (const)
        public const string Password = "admin"; 

        public static void checkCredentials(string login, string password)
        {
            if(login != Login || password != Password)
            {
                Console.Clear();
                Console.WriteLine("Invalid Login or Password");
                Environment.Exit(0);
            }

            Console.Clear();
            Console.WriteLine("Entering on System...");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
