using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    
                    Console.WriteLine(number + " divided by " + numberOne + " = " + number / numberOne);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero.");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
