using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //Loops 5 times
            {
                for (int j = 1; j <= i; j++)//Loops as many times as the value of i in the previous loop
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            for (int k = 5; k >= 1; k--) //Loops 5 times counting down from 5 to 1, displays 1st column
            {
                for (int m = k; m >= 1; m--)//starts with the value of k in the previous loop and decrement, displaying as many times  as the number in the previous loop
                {
                    Console.Write(k);
                }
                Console.Write("\n");
            }
                Console.ReadKey();
        }
    }
}
