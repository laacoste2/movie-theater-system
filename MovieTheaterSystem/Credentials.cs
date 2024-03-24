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
        public const string Login = "user";                       //Nome começando em maiusculo por convenção (const)
        public const string Password = "user";
        public const string LoginAdmin = "admin";                       
        public const string PasswordAdmin = "admin";
        public static bool isAdmin;

        public static void CheckCredentials(string login, string password)
        {
            if(login == Login && password == Password)
            {
                enteringSystemMessage("Entering on System");
                isAdmin = false;
            }
            else if(login == LoginAdmin && password == PasswordAdmin)
            {
                enteringSystemMessage("Entering on Admin System");
                isAdmin = true;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Login or Password");
                Environment.Exit(0);
            }

        }

        public static void enteringSystemMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
