using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths math = new Maths();

            Console.WriteLine("Please submit an integer.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int total= math.Sum(num1);
            Console.WriteLine(total);

            Console.WriteLine("Please submit a decimal.");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            total = math.Sum(num2);
            Console.WriteLine(total);


            Console.WriteLine("Please submit an string.");
            string num3 = Console.ReadLine();
            total = math.Sum(num3);
            Console.WriteLine(total);            
            Console.ReadLine();
        }
    }
}
