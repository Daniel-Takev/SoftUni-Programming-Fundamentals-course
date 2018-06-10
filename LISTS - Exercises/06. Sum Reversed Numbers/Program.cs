using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersList = Console.ReadLine().Split(' ').ToList();

            long sum = 0;

            foreach (string number in numbersList)
            {
                char[] reversedDigits = number.ToCharArray().Reverse().ToArray();
                //Array.Reverse(charArray);

                string digit = new string(reversedDigits);

                sum += int.Parse(digit);
            }

            // int sum = Console.ReadLine().Split().Select(e => new String(e.Reverse().ToArray())).Sum(e => int.Parse(e));

            Console.WriteLine(sum);
        }
    }
}