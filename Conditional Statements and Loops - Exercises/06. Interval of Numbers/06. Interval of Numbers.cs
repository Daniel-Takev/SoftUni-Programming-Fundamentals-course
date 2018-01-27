using System;

namespace _06._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                do
                {
                    Console.WriteLine(b);
                    b++;

                } while (b <= a);
            }
            else
            {
                do
                {
                    Console.WriteLine(a);
                    a++;

                } while (b >= a);
            }
        }
    }
}
