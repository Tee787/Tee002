using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width;
            double area, perimeter;
            Console.Write("Enter the length of the rectangle  " );
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the Width of the Rectangle  " );
            width = double.Parse(Console.ReadLine());
            area = length * width;
            perimeter = 2 * (length + width);
            Console.WriteLine("The area is "  + area);
            Console.WriteLine("The perimeter is "  + perimeter);
            Console.ReadKey();
        }
    }
}
