using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterSystem
{
    internal class HoursToChoose
    {
        public static DateTime threePM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0);
        public static DateTime fourPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 0, 0);
        public static DateTime fivePM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);
        public static DateTime sixPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
        public static DateTime sevenPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 0, 0);
        public static DateTime eightPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 0, 0);
        public static DateTime ninePM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 0, 0);
        public static DateTime tenPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 22, 0, 0);
        public static DateTime elevenPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);
        public static DateTime midnightPM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

        public static DateTime chooseHour(string hour)
        {
            if (hour == "Three") { return HoursToChoose.threePM; }
            else if (hour == "Four") { return HoursToChoose.fourPM; }
            else if (hour == "Five") { return HoursToChoose.fivePM; }
            else if (hour == "Six") { return HoursToChoose.sixPM; }
            else if (hour == "Seven") { return HoursToChoose.sevenPM; }
            else if (hour == "Eight") { return HoursToChoose.eightPM; }
            else if (hour == "Nine") { return HoursToChoose.ninePM; }
            else if (hour == "Ten") { return HoursToChoose.tenPM; }
            else if (hour == "Eleven") { return HoursToChoose.elevenPM; }
            else if (hour == "Midnight") { return HoursToChoose.midnightPM; }
            else { return fourPM; }

        }
    }
}
