using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;
            var temporalCount = 0;
            int[] temporalLength = new int[n.Length];
            int[] trueLength = new int[n.Length];

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
                    if (n[i] == n[j])
                    {
                        temporalLength[temporalCount] = n[i];
                        temporalCount++;
                        temporalLength[temporalCount] = n[j];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(string.Join(" ", n[0]));
                return;
            }
            var final = new int[count + 1];
            Array.Copy(trueLength, final, final.Length);

            Console.WriteLine(string.Join(" ", final));
        }
    }
}