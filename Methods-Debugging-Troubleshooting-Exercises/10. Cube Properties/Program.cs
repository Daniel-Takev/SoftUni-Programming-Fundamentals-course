using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:f2}", Calculating(cubeSide, parameter));
        }

        static double Calculating(double cubeSide, string par)
        {
            double result = 0.0;

            switch (par)
            {
                case "face": result = Math.Sqrt(2 * cubeSide * cubeSide); break;
                case "space": result = Math.Sqrt(3 * cubeSide * cubeSide); break;
                case "volume": result = cubeSide * cubeSide * cubeSide; break;
                case "area": result = 6 * cubeSide * cubeSide; break;
            }
            return result;
        }
    }
}