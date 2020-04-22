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

                int outer;
                int inner;

                for(outer = 2; outer < 100; outer++)
                {
                    for (inner = 2; inner <= (outer / inner); inner++)
                        if ((outer % inner) == 0) break;
                    if (inner > (outer / inner))
                        Console.WriteLine("{0} is prime", outer);
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
