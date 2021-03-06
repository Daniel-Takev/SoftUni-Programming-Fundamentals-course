﻿using System;

namespace _16.Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToUpper();
            long result = 0;

            while (command != "END")
            {
                string[] codeArgs = command.Split(' ');

                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }
                Console.WriteLine(result);
                command = Console.ReadLine();
            }
        }
    }
}
