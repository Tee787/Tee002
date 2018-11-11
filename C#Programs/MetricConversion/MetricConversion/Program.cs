using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string Code;
            decimal Total = 0;
            string Centimeters = "";

            decimal Length = 0;
            decimal Weight = 0;

            Boolean menu = true;

            do
            {
                Console.WriteLine("Metric Conversion Calculator");
                Console.WriteLine("Please choose from the conversion menu below ");
                Console.WriteLine("");
                Console.WriteLine("Inches to Centimeters " + "CODE: LENGTH");
                Console.WriteLine("Pounds to Kilograms " + "CODE: WEIGHT");
                Console.WriteLine("");
                Console.WriteLine("Please enter the Code ");
                Code = Console.ReadLine().ToUpper();

                if (Code == "Length")
                {
                    //Centimeters = Inches * 2.54;
                    //Total = Inches * 2.54;
                }
                var check = Console.ReadLine().ToUpper();
                if (check =="N")
                { menu = false; }
                Console.Clear();
            } while (menu);



        }
    }
}
