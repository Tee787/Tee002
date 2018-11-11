using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnIfAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please enter a number between 1 and 20");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10) Console.WriteLine("Number is greater than 10");
            else if (number < 10) Console.WriteLine("Number is less than 10");
            else Console.WriteLine("Number is equal than 10");

            Console.ReadKey();
        }   
    }
}
