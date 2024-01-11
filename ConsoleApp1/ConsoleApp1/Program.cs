using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //string[] stringList = new string[] { "Hello", "Goodbye", "Maybe", "Howdy", "Hi" };
        //Console.WriteLine("Please choose a number between 0 - 5.");
        //int firstChoice = Convert.ToInt32(Console.ReadLine());
        //if (firstChoice >= 0 || firstChoice < 5 )
        //{
        //    Console.WriteLine(stringList[firstChoice]);
        //}
        //else
        //{ Console.WriteLine("That is not a valid choice."); }

        //string[] numArray = new string[] { "Hello", "Goodbye", "Maybe", "Howdy", "Hi" };
        //Console.WriteLine("Please choose a number between 0-4.");
        //int choice = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(numArray[choice]);
        //Console.ReadLine();

        int[] testScores = { 98, 90, 99, 85, 70, 82, 34, 90 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
            
        }
        Console.ReadLine();
    }
}

