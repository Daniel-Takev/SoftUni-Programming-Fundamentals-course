using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var textItems = Console.ReadLine();

            var pattern = @"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b";
            var reg = new Regex(pattern);
            var matches = reg.Matches(textItems);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
