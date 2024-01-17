using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    public class Maths
    {
        public int Sum(int num1)
        {
            int total;
            total = num1 + 10;
            return total;
        }

        public int Sum(decimal num2)
        {
            int total = Convert.ToInt32(num2 * 100);
            return total;
        }
        public int Sum(string num3)
        {
            try
            {
                int total = Convert.ToInt32(num3) - 1;
                return total;
            }
            catch (FormatException ex)
            {
                
                Console.WriteLine("That is not a number");
                return 0;
            }
        }
    }
}
