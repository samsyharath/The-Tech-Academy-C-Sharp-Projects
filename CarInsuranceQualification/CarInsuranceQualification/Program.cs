using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? \"true\" or \"false\"");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many Speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            bool qualified = age > 15 && dui == false && speedingTickets < 3;

            Console.WriteLine("qualified?: " + qualified);

        }
    }
}
