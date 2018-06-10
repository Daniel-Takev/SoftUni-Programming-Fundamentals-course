﻿using System;

namespace _15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 112)
                {
                    hasMatch = true;
                    int endIndex = 0;

                    try
                    {
                        endIndex = jump + 1;
                        if (endIndex > text.Length)
                        {
                            endIndex = text[i];
                        }
                        string matchedString = text.Substring(i, endIndex);
                        Console.WriteLine(matchedString);
                        i += jump;
                    }
                    catch (Exception)
                    {
                        try
                        {
                            endIndex = jump;
                            if (endIndex > text.Length)
                            {
                                endIndex = text[i];
                            }
                            string matchedString = text.Substring(i, endIndex);
                            Console.WriteLine(matchedString);
                            i += jump;
                        }
                        catch (Exception)
                        {
                        }
                    }

                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}