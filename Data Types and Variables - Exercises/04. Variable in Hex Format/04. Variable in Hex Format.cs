using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class 04. Variable in Hex Format
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex, 16);

            Console.WriteLine(dec);
        }
    }
}