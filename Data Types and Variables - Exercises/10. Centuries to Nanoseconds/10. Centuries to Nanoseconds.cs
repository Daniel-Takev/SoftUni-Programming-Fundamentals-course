using System;

namespace _10.Centuries_to_Nanoseconds
{
    class 10. Centuries to Nanoseconds
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(365.2422 * years);
            int hours = 24 * days;
            long minutes = 60 * hours;
            long seconds = 60 * minutes;
            long milliseconds = 1000 * seconds;
            long microseconds = 1000 * milliseconds;
            decimal nanoseconds = 1000 * (decimal)microseconds;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} " +
                              $"days = {hours} hours = {minutes} minutes = {seconds} " +
                              $"seconds = {milliseconds} milliseconds = {microseconds} " +
                              $"microseconds = {nanoseconds} nanoseconds");
        }
    }
}