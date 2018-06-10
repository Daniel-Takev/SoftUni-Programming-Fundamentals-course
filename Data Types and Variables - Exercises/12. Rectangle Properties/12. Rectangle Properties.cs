using System;

namespace _12.Rectangle_Properties
{
    class 12. Rectangle Properties
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var perimeter = (2 * w + 2 * h);
            var area = (w * h);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(Math.Sqrt(w * w + h * h));
        }
    }
}