using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int currentStart = 0;
            int bestStart = 0;
            int currentCounter = 1;
            int BestCounter = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCounter++;

                    if (currentCounter > BestCounter)
                    {
                        BestCounter = currentCounter;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentCounter = 1;
                    currentStart = i;
                }
            }
            for (int i = bestStart; i < bestStart + BestCounter; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}