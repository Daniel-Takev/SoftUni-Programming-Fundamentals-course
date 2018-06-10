using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class 05. Boolean Variable
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool n = Convert.ToBoolean(text);
            if (n == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}