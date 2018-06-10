using System;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write("\\u{0:x4}", (int)text[i]);
            }

            Console.WriteLine();
        }
    }
}
