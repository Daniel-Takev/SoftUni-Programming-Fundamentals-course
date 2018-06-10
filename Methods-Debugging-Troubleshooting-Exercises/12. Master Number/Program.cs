using System;

namespace _12.Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {

                if (IsPalindrome(i) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int n)
        {
            int num = n;
            int reversed = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;

                reversed = reversed * 10 + lastDigit;
                n /= 10;
            }
            if (num == reversed)
            {
                return true;
            }
            return false;
        }

        static bool SumOfDigits(int n)
        {
            var sum = 0;
            bool isTrue = false;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            if (sum % 7 == 0)
            {
                isTrue = true;
            }
            return isTrue;
        }

        static bool ContainsEvenDigit(int n)
        {
            int separated = 0;
            bool isEven = false;
            while (n > 0)
            {
                separated = n % 10;
                n = n / 10;
                if (separated % 2 == 0)
                {
                    isEven = true;
                }
            }
            return isEven;
        }
    }
}