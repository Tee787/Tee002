using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int num1 = numberGenerator.Next(1,11);
            int num2 = numberGenerator.Next(1, 11);

            Console.WriteLine("What is " + num1 +   " times " + num2 + "?");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num1 * num2)
            {
                int responseIndex = numberGenerator.Next(1, 4);
                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("Well done, your answer is correct ");
                        break;
                    case 2:
                        Console.WriteLine("The answer is correct ");
                        break;
                    default:
                        Console.WriteLine("Have you been practising? ");
                        break;
                }
                }else
            {
                int diff = Math.Abs(answer - (num1 * num2));
                if (diff == 1)
                {
                    Console.WriteLine("Are you having some trouble? ");
                }
                else if (diff <= 10)
                {
                    Console.WriteLine("You can do better than that ");
                }
                else
                {
                    Console.WriteLine("You are not even close ");
                }                   
            }
            Console.ReadKey();
        }
    }
}
