using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 number1 = 0;
            Int32 number2 = 0;
            Int32 final = 0;
            String choice = "";
             
            Console.WriteLine("Welcome to my Calculator:");
            Console.Write("Please enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What do you want to do with these numbers: (+, *, / or -)");
            choice = Console.ReadLine();
                        
            Console.Write("Please enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            /*if (choice == "+")
            {
                final = number1 + number2;
            }
            if (choice == "*")
            {
                final = number1 * number2;
            }
            if (choice == "/")
            {
                final = number1 / number2;
            }
            if (choice == "-")
            {
                final = number1 - number2;
            }*/
            
            switch (choice)
            {
                case "+":
                    final = number1 + number2;
                    break;
                case "*":
                    final = number1 * number2;
                    break;
                case "-":
                    final = number1 - number2;
                    break;
                case "/":
                    final = number1 / number2;
                    break;
                default:
                    break;
            }

            /* Console.WriteLine($"The {choice} was applied");
             Console.Write($"The end result is: {final}\n    You are most welcome!)\n"); 
             Console.Write("Press any key to close.....");
             Console.ReadKey();
             */
            Console.WriteLine("The " + choice + " was applied");
            Console.Write("The end result is: {0}\n    You are most welcome!)\n", final);
            Console.Write("Press any key to close.....");
            Console.ReadKey();
        }
    }
}
