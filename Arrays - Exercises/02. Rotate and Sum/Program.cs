using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] rotated = new int[n.Length];
            Array.Copy(n, rotated, n.Length);
            var sum = new int[n.Length];

            for (int i = 0; i < k; i++)
            {
                rotated[0] = rotated[rotated.Length - 1];
                for (int j = 1; j < n.Length; j++)
                {
                    rotated[j] = n[j - 1];
                }
                for (int a = 0; a < n.Length; a++)
                {
                    sum[a] += rotated[a];
                }
                Array.Copy(rotated, n, rotated.Length);
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}