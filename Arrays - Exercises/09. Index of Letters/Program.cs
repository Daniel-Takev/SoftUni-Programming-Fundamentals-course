using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                Console.WriteLine($"{ch} -> {alphabet.IndexOf(ch)}");
            }
        }
    }
}