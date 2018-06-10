using System;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());
            Reversed(number);
            Console.WriteLine();
        }

        private static void Reversed(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
        }
    }
}