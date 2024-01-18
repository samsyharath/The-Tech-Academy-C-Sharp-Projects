using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            //employee.SayName();
            Employee<string> stringEmployee = new Employee<string>
            {
                Id = 1,
                FirstName = "John"
            };

            // Assign a list of strings as the property value of Things
            stringEmployee.Things.Add("Thing1");
            stringEmployee.Things.Add("Thing2");
            stringEmployee.Things.Add("Thing3");

            // Instantiate an Employee object with type "int"
            Employee<int> intEmployee = new Employee<int>
            {
                Id = 2,
                FirstName = "Jane"
            };

            // Assign a list of integers as the property value of Things
            intEmployee.Things.Add(1);
            intEmployee.Things.Add(2);
            intEmployee.Things.Add(3);

            // Print Things for the stringEmployee
            Console.WriteLine($"Employee {stringEmployee.FirstName}'s Things:");
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            // Print Things for the intEmployee
            Console.WriteLine($"\nEmployee {intEmployee.FirstName}'s Things:");
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
