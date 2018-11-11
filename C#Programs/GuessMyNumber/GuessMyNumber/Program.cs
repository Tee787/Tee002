using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            int userNum;

            Console.Write("I am thinking of a number between 1 and 10, can you guess what it is ");
            userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum == myNum)
            {
                Console.WriteLine("Good on you - you guessed my number!");
            }
            else
            {
                if (userNum > myNum) Console.WriteLine("That number is too high!");
                else Console.WriteLine("That number is too low!");
            }
            Console.ReadKey();
        }
    }
}
