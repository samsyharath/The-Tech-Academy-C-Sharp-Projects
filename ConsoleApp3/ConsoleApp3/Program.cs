using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            MathOperations.DividedByTwoAndOutput(userInput);

            int multiplyResult;
            MathOperations.MultiplyByTwoAndOutput(userInput, out multiplyResult);
            Console.WriteLine($"Result of multiplying {userInput} by 2: {multiplyResult}");
            double doubleInput = 10.5;
            double doubleResult;
            MathOperations.MultiplyByTwoAndOutput(doubleInput, out doubleResult);
            Console.WriteLine($"Result of multiplying {doubleInput} by 2: {doubleResult}");
            Console.ReadLine();
        }
    }
}
