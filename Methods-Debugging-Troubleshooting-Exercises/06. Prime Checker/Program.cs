using System;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(Prime(n));
        }

        static bool Prime(long n)
        {
            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}