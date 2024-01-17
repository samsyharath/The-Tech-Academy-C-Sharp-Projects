using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationOptional
{
    class Program
    {
        public static void Main()
        {
            MathOperations MathOperation = new MathOperations();
            Console.WriteLine("Please provide an integer.");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide a second integer. This is optional");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            MathOperations.Sum(int firstNumber, int secondNumber = 10);
            
            Console.ReadLine();
        }
    }
}
