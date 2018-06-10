using System;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split().ToArray();
            var baseNum = BigInteger.Parse(inputNums[0]);
            var numsToConvert = BigInteger.Parse(inputNums[1]);

            string result = string.Empty;

            while (numsToConvert > 0)
            {
                var remainder = numsToConvert % baseNum;
                result = remainder.ToString() + result;
                numsToConvert /= baseNum;
            }

            Console.WriteLine(result);
        }
    }
}
