using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnWhatsMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            int userNum;
            Console.Write("I am thinking of a number between 1 and 10. Can you guess what it is");
            userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum == myNum)
            {
                Console.WriteLine("Yes - You guessed my number!!");
            }
            else
            {
                if (userNum > myNum) Console.WriteLine("That number is too high");
                else Console.WriteLine("That number is too low");
            }
            Console.ReadKey();

        }
    }
}
