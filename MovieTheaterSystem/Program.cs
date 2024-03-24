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

            Credentials.CheckCredentials(login, password);
            if (Credentials.isAdmin == true)
            {
                Console.WriteLine("You entered on Admin Mode \n");
                Console.WriteLine("Now you can add and remove Movies from the list:");
                Console.WriteLine("To [A]dd | To [R]emove");
                string addOrRemove = Console.ReadLine();

                if (addOrRemove == "A")
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
                else if(addOrRemove == "R")
                {
                    Console.Clear();

                    Console.WriteLine("You chosen to remove a Movie\n");

                    Console.WriteLine("Type the name: ");
                    string movieToRemove = Console.ReadLine();

                    movies.RemoveAll(m => m.Name == movieToRemove);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Option");
                }

            }
            else
            {

            } 
            
            
           

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