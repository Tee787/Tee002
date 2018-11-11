using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableYouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            int countofBooks = 5;
            string myName = "John";
            bool IsCompatible = true;
            string number = "2";
            int numberConverted = Convert.ToInt32(number);

            Console.WriteLine(countofBooks);
            Console.WriteLine(myName);
            Console.WriteLine(IsCompatible);
            Console.WriteLine(number);
            Console.WriteLine(numberConverted);

            Console.ReadLine();
        }
    }
}
