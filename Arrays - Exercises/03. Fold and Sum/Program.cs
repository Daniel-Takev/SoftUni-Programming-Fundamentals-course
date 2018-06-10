using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", num));

        //int[] k = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //var count = 0;
        //int[] left = new int[k.Length / 2];
        //int[] mid = new int[k.Length / 2];
        //int[] right = new int[k.Length / 2];

        ////left
        //for (int i = k.Length / 4 - 1; i >= 0; i--)
        //{
        //    left[count] = k[i];
        //    count++;
        //}
        ////mid
        //for (int j = k.Length / 4; j<k.Length / 2 + count; j++)
        //{
        //    mid[j - count] = k[j];
        //}
        ////right
        //for (int i = k.Length - 1; i >= k.Length / 4 + count; i--)
        //{
        //    right[count] = k[i];
        //    count++;
        //}

        //int[] total = new int[k.Length / 2];
        //for (int i = 0; i<k.Length/2; i++)
        //{
        //    total[i] = left[i] + mid[i]+right[i];
        //}

        //Console.WriteLine(string.Join(" ", total));
        }
    }
}