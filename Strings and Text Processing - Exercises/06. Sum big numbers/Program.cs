using System;
using System.Linq;
using System.Text;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            int sum = 0;
            int reminder = 0;
            int checkNum = 0;
            StringBuilder strBuild = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--) // reversed loop
            {
                sum = (num1[i]) - 48 + (num2[i] - 48) + reminder; //-> [i] takes the last digit
                checkNum = sum % 10;
                if (sum > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
                strBuild.Append(checkNum); 
            }

            if (reminder == 1)
            {
                strBuild.Append(reminder);
            }

            Console.WriteLine(strBuild.ToString().TrimEnd('0')
                    .ToCharArray().Reverse().ToArray());
        }
    }
}