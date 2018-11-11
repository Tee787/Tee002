using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPractiveX
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Please enter a number between 1 and 20");
            x = Convert.ToInt32(Console.ReadLine());

            if (x > 10) Console.WriteLine("x is greater than 10");
            else if (x < 10) Console.WriteLine("x is less than 10");
            else Console.WriteLine("x is equal to 10");

            Console.ReadKey();
        }
    }
}
