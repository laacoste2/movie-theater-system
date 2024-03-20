namespace MovieTheaterSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Mickey", "Action", "01:30");

            Console.WriteLine("Your login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Your password: ");
            string password = Console.ReadLine();

            Credentials.checkCredentials(login, password);

            movie1.printSeats();
        }
    }
}