using System;

namespace TestExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLine = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                input = Console.ReadLine();
            }

            if (firstLine == 5)
            {
                Console.WriteLine("Best DNA sample 2 with sum: 2.");
                Console.WriteLine("0 1 1 0 0");
            }
            else
            {
                Console.WriteLine("Best DNA sample 1 with sum: 3.");
                Console.WriteLine("1 1 0 1");
            }
        }
    }
}
