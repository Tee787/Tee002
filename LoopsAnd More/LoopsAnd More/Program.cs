using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAnd_More
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter number: ");

            number = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Value of number = " + number);

                number++;

            }
            while (number <= 20);

            Console.ReadLine();
        }
    }
}
