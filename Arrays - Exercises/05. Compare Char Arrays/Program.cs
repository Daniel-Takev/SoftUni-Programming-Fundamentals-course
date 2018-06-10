using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ').ToArray();
            string[] k = Console.ReadLine().Split(' ').ToArray();

            if (n.Length <= k.Length && n[0] == "a")
            {
                for (int i = 0; i < n.Length; i++)
                {
                    Console.Write(n[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < k.Length; i++)
                {
                    Console.Write(k[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < k.Length; i++)
                {
                    Console.Write(k[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < n.Length; i++)
                {
                    Console.Write(n[i]);
                }
                Console.WriteLine();
            }
        }
    }
}