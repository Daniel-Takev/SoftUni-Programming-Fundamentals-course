using System;

namespace _16.Comparing_floats
{
    class 16. Comparing floats
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var difference = Math.Abs(a - b);

            const double precision = 0.000001;

            if (difference < precision)
            {
                Console.WriteLine("True"); 
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
