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
               for(int counter = 0; counter < 100; counter++)
                {
                    Console.WriteLine($"Counter is at: {counter}");
                    Console.WriteLine($"Twice the counter is : {counter * 2}");
                }

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
