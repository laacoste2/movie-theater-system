using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterSystem
{
    internal class UserAdmin
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
                EnteringSystemMessage("Entering on System...");
                isAdmin = false;
            }
            else if(login == LoginAdmin && password == PasswordAdmin)
            {
                EnteringSystemMessage("Entering on Admin System...");
                isAdmin = true;

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Login or Password");
                Environment.Exit(0);
            }

        }

        public static void EnteringSystemMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static void AddMovie(List<Movie> movies)
        {
            Console.Clear();

            Console.WriteLine("You choosen to add a Movie\n");

            Console.WriteLine("Type the name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Type the genre: ");
            string genre = Console.ReadLine();

            Console.WriteLine("Type the duration: ");
            string duration = Console.ReadLine();

            Console.WriteLine("Type the hour that the movie will show ");
            Console.WriteLine("Available Hours (PM): Three, Four, Five, Six, Seven, Eight, Nine, Ten, Eleven, Midnight");
            string hour = Console.ReadLine();

            DateTime hourObject = HoursToChoose.chooseHour(hour);

            movies.Add(new Movie(name, genre, duration, hourObject));
        }

        public static void RemoveMovie(List<Movie> movies)
        {
            Console.Clear();

            Console.WriteLine("You chosen to remove a Movie\n");

            Console.WriteLine("Type the name: ");
            string movieToRemove = Console.ReadLine();

            movies.RemoveAll(m => m.Name == movieToRemove);
        }

        public static void UpdateMovie(List<Movie> movies)
        {
            Console.Clear();

            Console.WriteLine("You chosen to update a movie");
            Console.WriteLine("\nType the name of the movie that you want to update: ");
            string update = Console.ReadLine();

            foreach (Movie movie in movies)
            {
                if(movie.Name == update)
                {
                    Console.WriteLine("\nMovie " + update + " was found");

                    Console.WriteLine("\nType the new name");
                    string newName = Console.ReadLine();

                    Console.WriteLine("\nType the new genre");
                    string newGenre = Console.ReadLine();

                    Console.WriteLine("\nType the new duration");
                    string newDuration = Console.ReadLine();

                    Console.WriteLine("\nType the new hour");
                    Console.WriteLine("Available Hours (PM): Three, Four, Five, Six, Seven, Eight, Nine, Ten, Eleven, Midnight");
                    string newHour = Console.ReadLine();

                    DateTime hourObject = HoursToChoose.chooseHour(newHour);
                    

                    movie.Name = newName;
                    movie.Genre = newGenre;
                    movie.Duration = newDuration;
                    movie.hourString = hourObject.ToString("HH:mm");
                }
            }
        }

        public static void SeeMovies(List<Movie> movies)
        {
            Console.Clear();
            Movie.PrintMovies(movies);
        }
    }
}
