using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').ToArray();
            var second = Console.ReadLine().Split(' ').ToArray();

            var counter1 = 0;
            var counter2 = 0;

            for (int i = 0; i < Math.Min(second.Length, first.Length); i++)
            {
                if (first[i % first.Length] == second[i % second.Length])
                {
                    counter1++;
                }
            }
            for (int i = Math.Min(first.Length, second.Length) - 1; i >= 0; i--)
            {
                if (first[first.Length - 1 - i] == second[second.Length - 1 - i])
                {
                    counter2++;
                }
            }
            if (counter1 > counter2)
            {
                Console.WriteLine(counter1);
            }
            else
            {
                Console.WriteLine(counter2);
            }

        }
    }
}