using System;

namespace _03._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometeres = double.Parse(Console.ReadLine());
            double miles = (kilometeres * 1.60934);

            //1 mile == 1.60934 kilometers
            Console.WriteLine($"{miles:F2}");
        }
    }
}
