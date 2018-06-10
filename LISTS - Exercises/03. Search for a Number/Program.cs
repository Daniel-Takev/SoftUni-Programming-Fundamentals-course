﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] arrData = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            ExecuteProgram(numbersList, arrData);

        }

        private static void ExecuteProgram(List<int> numbersList, int[] arrData)
        {

            numbersList = numbersList.Take(arrData[0]).ToList();
            numbersList.RemoveRange(0, arrData[1]);
            Console.WriteLine(numbersList.Contains(arrData[2]) ? "YES!" : "NO!");
        }
    }
}