using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static int Fib(int n)
        {
            var first = 0;
            var second = 1;

            for (int i = 0; i <= n; i++)
            {
                var next = first + second;
                first = second;
                second = next;
            }

            return first;
        }
    }
}