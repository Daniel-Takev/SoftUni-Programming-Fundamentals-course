using System;

namespace _18.Different_Integers_Size
{
    class 18. Different Integers Size
    {
        static void Main(string[] args)
        {
            var input = (Console.ReadLine());

            try
            {
                var n = long.Parse(input);

                Console.WriteLine("{0} can fit in:", n);
                if (n >= -128 && n <= 127)  // (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (n >= 0 && n <= 255)
                {
                    Console.WriteLine("* byte");
                }
                if (n >= -32768 && n <= 32767)
                {
                    Console.WriteLine("* short");
                }
                if (n >= 0 && n <= 65535)
                {
                    Console.WriteLine("* ushort");
                }
                if (n >= -2147483648 && n <= 2147483647)
                {
                    Console.WriteLine("* int");
                }
                if (n >= 0 && n <= 4294967295)
                {
                    Console.WriteLine("* uint");
                }
                if (n >= -9223372036854775808 && n <= 9223372036854775807)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}