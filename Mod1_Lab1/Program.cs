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

            try
            {
                int result = Sum(20, 40);
                Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

                int result3 = Sum(10, 50, 80);
                Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

                double dblResult = Sum(20.5, 30.6);
                Console.WriteLine($"Calling Sum() with two doubles, result in: {dblResult}");
            }
            finally
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }

        }

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
