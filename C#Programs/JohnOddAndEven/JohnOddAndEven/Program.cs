using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnOddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int R, num;
            int i = 0;
            while (i == 0)
            {
                Console.Write("Please enter any number: ");
                num = Convert.ToInt32(Console.ReadLine());
                R = num % 2;
                if (R == 0) Console.WriteLine("That number is an even number");
                else Console.WriteLine("That number is an odd number");
                Console.ReadKey();
            }

        }
    }
}
