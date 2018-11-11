using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubMultDivide
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int result;
            Console.Write("\n Enter the first number to be added:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the second number to be added:");
            y = Convert.ToInt32(Console.ReadLine());
            result = x + y;
            Console.Write("\n The sum of the two numbers is: " + result);
            Console.ReadLine();

           
           Console.ReadLine();
        }
    }
}
