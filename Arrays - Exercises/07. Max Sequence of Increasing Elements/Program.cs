using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] temporalLength = new int[n.Length];
            int[] trueLength = new int[n.Length];
            var count = 0;
            var temporalCount = 0;

            for (int i = 0; i < n.Length; i++)
            {
                if (temporalCount > count)
                {
                    count = temporalCount;
                    trueLength = temporalLength;
                }
                temporalLength = new int[n.Length];
                temporalCount = 0;
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i + temporalCount] < n[j])
                    {
                        temporalLength[temporalCount] = n[j - 1];
                        temporalCount++;
                        temporalLength[temporalCount] = n[j];
                    }
                    else
                    break;
                }
            }
            var final = new int[count + 1];
            Array.Copy(trueLength, final, final.Length);
            Console.WriteLine(string.Join(" ", final));
        }
    }
}