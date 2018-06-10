using System;

namespace _07.Exchange_Variable_Values
{
    class 07. Exchange Variable Values
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", b);
            Console.WriteLine("b = {0}", a);
        }
    }
}