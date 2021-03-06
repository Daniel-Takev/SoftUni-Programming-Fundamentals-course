﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    if (Math.Abs(sequence[i] - sequence[j]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}