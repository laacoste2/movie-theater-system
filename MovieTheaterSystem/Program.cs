using System;

namespace MovieTheaterSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Mickey", "Action", "01:30"));
            movies.Add(new Movie("Barbie: The return of Darth Vader", "Drama", "02:00")); //Drama em inglês é Drama

            Console.WriteLine("Your login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Your password: ");
            string password = Console.ReadLine();

            Credentials.CheckCredentials(login, password);

            Console.Write("Choose the Movie that you want by typing its name:\n");
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.ToString());
            }

            string movieChoose = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(movieChoose))
            {
                foreach (Movie movie in movies)
                {
                    if (movie.Name ==  movieChoose)
                    {
                        Console.Clear();
                        Console.WriteLine("Chosen moovie: " + movie.Name + "\n");
                        Console.WriteLine("[B]uy Ticket");
                        string buyTicket = Console.ReadLine();
                        if(buyTicket == "B")
                        {
                            Console.Clear();
                            Console.WriteLine("Choose a seat:\n");

                            while (movie.isValidSeat == false)
                            {
                                movie.PrintSeats();
                                int chosenSeat = int.Parse(Console.ReadLine());
                                for (int i = 0; i < movie.seats.GetLength(0); i++)
                                {
                                    for (int j = 0; j < movie.seats.GetLength(1); j++)
                                    {
                                        if (movie.seats[i, j] == chosenSeat)
                                        {
                                            movie.isValidSeat = true;
                                            break;
                                        }
                                    }

                                    if (movie.isValidSeat)
                                        Console.WriteLine("\n The seat " + chosenSeat + " has been chosen");
                                        break;
                                }
                            }

                            if (movie.isValidSeat)
                            {
                            }
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