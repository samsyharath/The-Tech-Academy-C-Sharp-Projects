using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationOptional
{
    public class MathOperations
    {
        public MathOperations(int firstNumber, int secondNumber = 10)
        {
            Console.WriteLine("Please provide an integer.");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide a second integer. This is optional");
            secondNumber = Convert.ToInt32(Console.ReadLine()); 
            int result = firstNumber + secondNumber; //second number is optional but default is 10
            Console.WriteLine(result);
        }
    }
}
