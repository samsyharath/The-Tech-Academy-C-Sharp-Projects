using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>() { "word1", "word2", "word3", "word4" };
        words.Add(Console.ReadLine());

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }

        List<int> scores = new List<int>() { 12, 15, 20, 60, 40, 50 };

        for (int s = 0; s < scores.Count; s++ )
        {
            if (scores[s] <= 50)
            {
                Console.WriteLine("You failed.");
            }
            else
            {
                Console.WriteLine("You passed with a score of: " + scores[s]);
            }
        }

        List<string> studentIDs = new List<string>() { "001", "002", "003", "004"};
        Console.WriteLine("Please enter your student ID number.");

        string yourID = (Console.ReadLine());

            foreach (string studentID in studentIDs)
                if (studentIDs.Contains(yourID) && studentID == yourID)
                {
                    Console.WriteLine("Your ID is: " + yourID + " and you are logged in.");
                }
                else if (studentIDs.Contains(yourID) && studentID != yourID)
                { }
                else
                {
                    Console.WriteLine("Your ID is not valid.");
                    break;
                }


        Console.ReadLine();
    }
}
