using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnCaseAddMultDivideSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1, Num2, total;
            int symbol = 0;
            string operation = "";

            Console.Write("Enter First Number:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number:");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n**********************");
            Console.WriteLine("Press \"1\" for Addition");
            Console.WriteLine("Press \"2\" for Suntraction");
            Console.WriteLine("Press \"3\" for Multiplication");
            Console.WriteLine("Press \"4\" for Division");

            Console.WriteLine("************************");

            symbol = Convert.ToInt32(Console.ReadLine());

            switch (symbol)
            {
                case 1:
                    {
                        operation = "Addition";
                        total = Num1 + Num2;
                        break;
                    }
                case 2:
                    {
                        operation = "Subtraction";
                        total = Num1 - Num2;
                        break;
                    }
                case 3:
                    {
                        operation = "Multiplication";
                        total = Num1 * Num2;
                        break;
                    }
                case 4:
                    {
                        operation = "Division";
                        total = Num1 / Num2;
                        break;
                    }
                default:
                    {
                        operation = "No operand chosen";
                        total = Num1 - Num2;
                        break;
                    }
            }
            Console.WriteLine("");
            Console.WriteLine("The {0} operation is requested of {1} and {2}. \n\nThe result is {3}", operation, Num1, Num2, total);
            Console.ReadKey();
        }
    }
}
