using System;

namespace _02._Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            if (profession == "Athlete")
            {
                totalPrice = quantity * 0.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                totalPrice = quantity * 1;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else if (profession == "SoftUni Student")
            {
                totalPrice = quantity * 1.7;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }
            else
            {
                totalPrice = quantity * 1.2;
                Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
            }

        }
    }
}
