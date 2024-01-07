using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            
            Console.WriteLine("What page are you on?");
            string yourPage = Console.ReadLine();
            int pageNum = Convert.ToInt32(yourPage);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpNeeded = Console.ReadLine();
            bool help = Convert.ToBoolean(helpNeeded);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studiedHours = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
