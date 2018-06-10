using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;

            do
            {
                fact = fact * n;
                n--;
            } while (n > 1);
            Console.WriteLine(ReturnZeroes(fact));
        }
        static int ReturnZeroes(BigInteger zero)
        {
            BigInteger temporal = 0;
            int zeroCount = 0;
            BigInteger stop = 0;

            while (zero > 0)
            {
                temporal = zero % 10;
                zero /= 10;
                if (temporal == 0)
                {
                    zeroCount++;
                }
                else
                {
                    zero = stop;
                }
            }
            return zeroCount;
        }
    }
}