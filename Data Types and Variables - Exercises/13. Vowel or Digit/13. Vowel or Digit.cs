﻿using System;

namespace _13.Vowel_or_Digit
{
    class 13. Vowel or Digit
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("vowel");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}