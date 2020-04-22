using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            try
            {
                int n = 1;
                while(n < 6)
                {
                    Console.WriteLine($"Current value of n is {n}");
                    n++;
                }

                int x = 0;
                do
                {
                    Console.WriteLine(x);
                    x++;
                } while (x < 5);
            }
            finally
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
#endif
        }
    }
}
