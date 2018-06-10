using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool ODD = false;
            bool EVEN = false;

            while (!(ODD || EVEN))
            {
                string[] cmd = Console.ReadLine().ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (cmd[0])
                {
                    case "delete":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            for (int a = 0; a < numbers.Count; a++)
                            {
                                if (int.Parse(cmd[1]) == numbers[a])
                                {
                                    numbers.Remove(int.Parse(cmd[1]));
                                }
                            }
                        }
                        break;
                    case "insert":
                        numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        break;
                    case "odd":
                        ODD = true;
                        break;
                    case "even":
                        EVEN = true;
                        break;
                }
            }
            //prints the result
            for (int i = 0; i < numbers.Count; i++)
            {
                if (ODD)
                {
                    if ((numbers[i]) % 2 != 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
                else
                {
                    if ((numbers[i]) % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}