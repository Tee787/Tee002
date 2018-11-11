using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnBasicLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N\t10*N\t100*N\t1000*N\n");
            for (int n = 1; n <= 5; n++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", n, n * 10, n * 100, n * 1000);
            }
            Console.ReadKey();

        }
    }
}
