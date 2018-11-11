using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnPinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 0;
            int pin2 = 0;
            Console.Write("Please enter your 4-digit pin number:");
            pin = Convert.ToInt32(Console.ReadLine());

            if ((pin < 1000) || (pin > 9999))
            {
                Console.Write("That is not a valid 4-digit pin, press any key to exit program");
            }
            else
            {
                Console.Write("Please re-enter your pin:");
                pin2 = Convert.ToInt32(Console.ReadLine());
                if (pin == pin2) Console.WriteLine("Your pin has been set");
                else Console.WriteLine("Error, your pin was not set!");
            }
            Console.ReadKey();

        }
    }
}
