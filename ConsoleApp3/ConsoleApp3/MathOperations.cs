using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class MathOperations
    {
        public static void DividedByTwoAndOutput(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Result of dividing {number} by 2: {result}");
        }

        public static void MultiplyByTwoAndOutput(int input, out int result)
        {
            result = input * 2;
        }

        public static void MultiplyByTwoAndOutput(double input, out double result)
        {
            result = input * 2;
        }
    }
}
