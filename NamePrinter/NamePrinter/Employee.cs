using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePrinter
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public void Quit()
        {
            Console.WriteLine("Quit");
        }

    }
}
