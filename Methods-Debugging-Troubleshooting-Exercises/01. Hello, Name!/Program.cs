using System;

namespace _01.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, {0}!", Name());
        }
        static string Name()
        {
            return (Console.ReadLine());
        }
    }
}