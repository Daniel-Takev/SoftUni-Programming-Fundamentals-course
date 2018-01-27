using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeGroup = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";
            double price = 0.0;
            double totalPrice = 0.0;

            if (sizeGroup <= 50)
            {
                price = 2500;
                hallName = "Small Hall";
                switch (package)
                {
                    case "Normal":
                        price += 500;
                        totalPrice = (price - (price * 0.05)) / sizeGroup;
                        break;
                    case "Gold":
                        price += 750;
                        totalPrice = (price - (price * 0.10)) / sizeGroup;
                        break;
                    case "Platinum":
                        price += 1000;
                        totalPrice = (price - (price * 0.15)) / sizeGroup;
                        break;
                }
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice:F2}$");
            }

            else if (50 < sizeGroup && sizeGroup <= 100)
            {
                price = 5000;
                hallName = "Terrace";

                switch (package)
                {
                    case "Normal":
                        price += 500;
                        totalPrice = (price - (price * 0.05)) / sizeGroup;
                        break;
                    case "Gold":
                        price += 750;
                        totalPrice = (price - (price * 0.10)) / sizeGroup;
                        break;
                    case "Platinum":
                        price += 1000;
                        totalPrice = (price - (price * 0.15)) / sizeGroup;
                        break;
                }
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice:F2}$");
            }

            else if (sizeGroup > 100 && sizeGroup <= 120)
            {
                price = 7500;
                hallName = "Great Hall";

                switch (package)
                {
                    case "Normal":
                        price += 500;
                        totalPrice = (price - (price * 0.05)) / sizeGroup;
                        break;
                    case "Gold":
                        price += 750;
                        totalPrice = (price - (price * 0.10)) / sizeGroup;
                        break;
                    case "Platinum":
                        price += 1000;
                        totalPrice = (price - (price * 0.15)) / sizeGroup;
                        break;
                }
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {totalPrice:F2}$");
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
