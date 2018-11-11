using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnTimeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ans = 0;

            Console.WriteLine("which timestable do you want to see?");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 13; i++)
            {
                Ans = num * i;
                Console.WriteLine("{0} * {1} = {2}", i, num, Ans);
            }

            Console.ReadKey();
        }

    }
}
