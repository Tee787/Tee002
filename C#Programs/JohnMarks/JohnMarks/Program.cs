using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mark;
            string Grade;

            Console.WriteLine("Please enter your Course Final Mark out of 100");
            Mark = Convert.ToInt32(Console.ReadLine());

            if (Mark >= 90) Grade = "A+";
            else if (Mark >= 80) Grade = "A";
            else if (Mark >= 70) Grade = "B+";
            else if (Mark >= 60) Grade = "B";
            else if (Mark >= 50) Grade = "C";
            else Grade = "F";

            Console.WriteLine("Your Grade is {0}", Grade);

            Console.ReadKey();

        }
    }
}
