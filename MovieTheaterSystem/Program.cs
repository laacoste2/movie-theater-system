using System;

namespace MovieTheaterSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Movie testMovie = new Movie();
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Mickey", "Action", "01:30", HoursToChoose.fivePM));
            movies.Add(new Movie("Barbie", "Drama", "02:00", HoursToChoose.elevenPM)); 
            movies.Add(new Movie("Batman", "Action", "02:30", HoursToChoose.fourPM));


            Console.WriteLine("Your login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Your password: ");
            string password = Console.ReadLine();

            Credentials.CheckCredentials(login, password);

            Console.WriteLine("Choose the Movie that you want by typing its name\n");
            Console.WriteLine("Movies availabe today: \n");
            Movie.PrintMovies(movies);

            string movieChoose = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(movieChoose))
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
        }
    }
}