using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1\nWhat is the hourly rate?");
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours worked per week?");
            int hoursWorked1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2\nWhat is the hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            int salaryPerson1 = hourlyRate1 * hoursWorked1 * 52;
            int salaryPerson2 = hourlyRate2 * hoursWorked2 * 52;

            Console.WriteLine("Annual salary of Person 1: " + salaryPerson1);
            Console.WriteLine("Annual salary of Person 2: " + salaryPerson2);

            bool greaterSalary = salaryPerson1 > salaryPerson2;

            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + greaterSalary);
            Console.ReadLine();
        }
    }
}
