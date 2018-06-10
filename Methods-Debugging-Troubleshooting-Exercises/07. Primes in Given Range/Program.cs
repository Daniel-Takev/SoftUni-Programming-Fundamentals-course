using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string numbers = string.Join(", ", FindPrimesInRange(start, end));
            Console.WriteLine(numbers);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var result = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}