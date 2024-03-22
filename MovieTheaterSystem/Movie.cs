using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterSystem
{
    internal class Movie
    {
        private string name;
        private string genre;
        private string duration;
        public int[,] seats = new int[,]
        {
            { 001, 002, 003, 004, 005, 006, 007, 008, 009, 010 },
            { 011, 012, 013, 014, 015, 016, 017, 018, 019, 020 },
            { 021, 022, 023, 024, 025, 026, 027, 028, 029, 030 },
            { 031, 032, 033, 034, 035, 036, 037, 038, 039, 040 },
            { 041, 042, 043, 044, 045, 046, 047, 048, 049, 050 },
            { 051, 052, 053, 054, 055, 056, 057, 058, 059, 060 },
            { 061, 062, 063, 064, 065, 066, 067, 068, 069, 070 },
            { 071, 072, 073, 074, 075, 076, 077, 078, 079, 080 },
            { 081, 082, 083, 084, 085, 086, 087, 088, 089, 090 },
            { 091, 092, 093, 094, 095, 096, 097, 098, 099, 100 }
        };

        public bool isValidSeat = false;
        public DateTime time;

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Duration { get => duration; set => duration = value; }

        public Movie(string name, string genre, string duration) 
        {
            this.name = name;
            this.genre = genre;
            this.duration = duration;
        }

        public void PrintSeats()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(seats[row, col].ToString("000") + " "); // Convert to string with leading zeros
                }
                Console.WriteLine();
            }
        }

        public static void ReturnChosenSeat(Movie movie, bool isValidSeat)
        {
            while (isValidSeat == false)
            {
                movie.PrintSeats();
                Console.WriteLine();
                int chosenSeat = int.Parse(Console.ReadLine());
                for (int i = 0; i < movie.seats.GetLength(0); i++)
                {
                    for (int j = 0; j < movie.seats.GetLength(1); j++)
                    {
                        if (movie.seats[i, j] == chosenSeat)
                        {
                            isValidSeat = true;
                            break;
                        }


                    }

                    if (isValidSeat)
                    {
                        Console.WriteLine("\n The seat " + chosenSeat + " has been chosen");
                        break;
                    }
                }
            }
        }
        
        public static void PrintMovies(List<Movie> movies, DateTime time)
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(time + movie.ToString());
            }
        }

        public override string ToString()
        {
            return "\n--------------------\n" +
                   "Movie: " + name + "\n" +
                   "Genre: " + genre + "\n" + 
                   "Duration: " + duration + "\n" + 
                   "--------------------\n";
        }
    }
}
