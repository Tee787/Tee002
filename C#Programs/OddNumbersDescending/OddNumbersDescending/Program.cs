using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 75; i>=5; i-= 2)
            {
                Console.WriteLine(i);
            }*/
            int num = 75;
            while (num >= 5)
            {
                Console.WriteLine(num);
                num -= 2;
            }
            Console.ReadKey();

        }
    }
}
