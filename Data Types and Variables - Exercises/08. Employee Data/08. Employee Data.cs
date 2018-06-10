using System;

namespace _08.Employee_Data
{
    class 08. Employee Data
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            int uniqueID = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", ID);
            Console.WriteLine("Unique Employee number: {0}", uniqueID);
        }
    }
}