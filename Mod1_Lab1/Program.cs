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
                bool result = true;
                if (result)
                    Console.WriteLine("Result is true");
                Console.WriteLine("Will this print as part of the if statement?");
                Console.WriteLine("Does this print at all?");
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
