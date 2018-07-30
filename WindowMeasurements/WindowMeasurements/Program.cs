using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowMeasurements
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;

            string widthString, heightString;

            Console.WriteLine("Enter width of window then press Enter");

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Enter height of window then press Enter");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height);

            glassArea = width * height;


            Console.WriteLine("The length of the wood is " + woodLength + " metres.");

            Console.WriteLine();

            Console.WriteLine("The area of the glass is " + glassArea + "metres squared");

        }
    }
}
