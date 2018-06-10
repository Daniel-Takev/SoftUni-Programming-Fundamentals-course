using System;
using System.Linq;
using System.Text;

namespace _17.Print_Part_Of_ASCII_Table
{
    class 17. Print Part Of ASCII Table
    {
        static void Main(string[] args)
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());

            for (char @char = (char)startIndex; @char <= endIndex; @char++)
            {
                Console.Write(@char + " ");
            }
        }
    }
}
