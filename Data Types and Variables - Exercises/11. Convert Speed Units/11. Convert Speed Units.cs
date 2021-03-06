﻿using System;

namespace _11.Convert_Speed_Units
{
    class 11. Convert Speed Units
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double s = hours * 60 * 60 + minutes * 60 + seconds;
            double h = s / 60 / 60;

            Console.WriteLine("{0:g7}", distance / s);
            Console.WriteLine("{0:g7}", (distance / h) / 1000);
            Console.WriteLine("{0:g7}", (distance / h) / 1609);
        }
    }
}