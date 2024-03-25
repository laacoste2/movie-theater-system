using System;

namespace MovieTheaterSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Mickey", "Action", "01:30", HoursToChoose.fivePM));
            movies.Add(new Movie("Barbie", "Drama", "02:00", HoursToChoose.elevenPM)); 
            movies.Add(new Movie("Batman", "Action", "02:30", HoursToChoose.fourPM));

            Console.WriteLine("Your login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Your password: ");
            string password = Console.ReadLine();

            UserAdmin.CheckCredentials(login, password);
            if (UserAdmin.isAdmin == true)
            {
                Console.WriteLine("You entered on Admin Mode \n");
                Console.WriteLine("Now you can do some things with the Movies from the list:");
                int x = 1;

                while(x == 1)
                {
                    Console.WriteLine("To [A]dd | To [R]emove | To [U]pdate | To [S]ee");
                    string addOrRemove = Console.ReadLine();

                    if (addOrRemove == "A")
                    {
                        UserAdmin.AddMovie(movies);
                        Console.Clear();

                        Console.WriteLine("Type 1 to return to the options | Type 2 to proceed on the user system");
                        int returnOrProceed = int.Parse(Console.ReadLine());

                        if(returnOrProceed == 1)
                        {
                            x = 1;
                        }
                        else if(returnOrProceed == 2)
                        {
                            x = 0;
                        }
                    }
                    else if (addOrRemove == "R")
                    {
                        UserAdmin.RemoveMovie(movies);
                        Console.Clear();

                        Console.WriteLine("Type 1 to return to the options | Type 2 to proceed on the user system");
                        int returnOrProceed = int.Parse(Console.ReadLine());

                        if (returnOrProceed == 1)
                        {
                            x = 1;
                        }
                        else if (returnOrProceed == 2)
                        {
                            x = 0;
                        }
                    }
                    else if (addOrRemove == "U")
                    {
                        UserAdmin.UpdateMovie(movies);
                        Console.Clear();

                        Console.WriteLine("Type 1 to return to the options | Type 2 to proceed on the user system");
                        int returnOrProceed = int.Parse(Console.ReadLine());

                        if (returnOrProceed == 1)
                        {
                            Console.Clear();
                            x = 1;
                        }
                        else if (returnOrProceed == 2)
                        {
                            Console.Clear();
                            x = 0;
                        }
                    }
                    else if (addOrRemove == "S")
                    {
                        UserAdmin.SeeMovies(movies);
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("Type 1 to return to the options | Type 2 to proceed on the user system");
                        int returnOrProceed = int.Parse(Console.ReadLine());

                        if (returnOrProceed == 1)
                        {
                            x = 1;
                        }
                        else if (returnOrProceed == 2)
                        {
                            x = 0;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Option");
                    }
                }
                

            }
            else
            {

            }

            Console.Clear();
            Console.WriteLine("Choose the Movie that you want by typing its name\n");
            Console.WriteLine("Movies availabe today: \n");
            Movie.PrintMovies(movies);

            string movieChoose = Console.ReadLine();

            Movie selectedMovie = movies.FirstOrDefault(m => m.Name == movieChoose);

            if (selectedMovie != null)
            {
                foreach (Movie movie in movies)
                {
                    if (movie.Name ==  movieChoose)
                    {
                        Console.Clear();
                        Console.WriteLine("Chosen Movie: " + movie.Name + "\n");

                        Console.WriteLine("[B]uy Ticket");
                        string buyTicket = Console.ReadLine();

                        if(buyTicket == "B")
                        {
                            Console.Clear();

                            Console.WriteLine("Choose a seat:\n");
                            Movie.ReturnChosenSeat(movie, false);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Option");
                        }
                    }
                    
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Movie not Found");
            }
        }
    }
}