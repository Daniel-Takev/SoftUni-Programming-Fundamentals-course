using System;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            FindTypeAndGetArea(figureType);
        }

        static void FindTypeAndGetArea(string type)
        {
            double first = double.Parse(Console.ReadLine());
            if (type == "square" || type == "circle")
            {
                switch (type)
                {
                    case "square":
                        Console.WriteLine("{0:f2}", first * first); break;

                    case "circle":
                        Console.WriteLine("{0:f2}", Math.PI * first * first); break;
                }
            }

            else
            {
                double second = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case "triangle":
                        Console.WriteLine("{0:f2}", 0.5 * (first * second)); break;

                    case "rectangle":
                        Console.WriteLine("{0:f2}", first * second); break;
                }
            }
        }
    }
}