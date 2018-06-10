using System;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(EnglishName(number));
        }

        static string EnglishName(long n)
        {
            n = Math.Abs(n);
            long lastNumber = n % 10;

            string name = string.Empty;
            switch (lastNumber)
            {
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
                case 0: name = "zero"; break;
            }

            return name;
        }
    }
}