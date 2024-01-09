﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try Again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29. Try Again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 59:
                        Console.WriteLine("You guessed 59. Try Again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            {

            }
            Console.ReadLine();
        }
    }
}
