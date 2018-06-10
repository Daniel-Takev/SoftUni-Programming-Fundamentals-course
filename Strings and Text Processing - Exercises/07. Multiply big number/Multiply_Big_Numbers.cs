using System;
using System.Linq;
using System.Text;

namespace _07.Multiply_big_number
{
    class Multiply_Big_Numbers
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int multiplyer = 0;
            int reminder = 0;
            int result = 0;
            StringBuilder stringBuild = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplyer = (num1[i] - '0') * num2 + reminder;
                result = multiplyer % 10;
                if (multiplyer > 9)
                {
                    reminder = multiplyer / 10;
                }
                else
                {
                    reminder = 0;
                }
                stringBuild.Append(result);
            }

            if (reminder > 0)
            {
                stringBuild.Append(reminder);
            }

            Console.WriteLine(stringBuild.ToString().TrimEnd('0').ToCharArray()
                .Reverse().ToArray());
        }
    }
}
