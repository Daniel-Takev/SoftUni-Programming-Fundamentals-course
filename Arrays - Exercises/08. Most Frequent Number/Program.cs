using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int temporalLength = 0;
            int trueLength = 0;
            var count = 0;
            var temporalCount = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (temporalCount > count)
                {
                    count = temporalCount;
                    trueLength = temporalLength;
                }
                temporalLength = 0;
                temporalCount = 0;
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] == n[j])
                    {
                        temporalLength = n[i];
                        temporalCount++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(n[0]);
            }
            else
            {
                Console.WriteLine(string.Join(" ", trueLength));
            }
        }
    }
}