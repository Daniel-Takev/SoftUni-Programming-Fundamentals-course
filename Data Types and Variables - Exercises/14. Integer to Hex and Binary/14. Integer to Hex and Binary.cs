using System;

namespace _14.Integer_to_Hex_and_Binary
{
    class 14. Integer to Hex and Binary
    {
        static void Main(string[] args)
        {
            var dec = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0:X}", dec));
            Console.WriteLine(Convert.ToString(dec, 2));
        }
    }
}