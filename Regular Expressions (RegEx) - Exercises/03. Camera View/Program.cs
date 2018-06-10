using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(", ", Regex.Matches(Console.ReadLine(), 
                @"\|<(.*?)(?=\||$)").Cast<Match>()
                .Select(e => string.Concat(e.Groups[1].ToString().Skip(elements[0])
                .Take(elements[1]).ToArray()))));
        }
    }
}
