//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Lists ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            int count = 0;

            //Create list for all the fName, lName in roster
            List<string> wVBRoster = new List<string>() {"Kelsey Carrington", "Paige Andersong", "Paige Johnson", "Kylee Mclaughlin", "Sanaa Dotson", "Sam Anthony", "Olivia Curtis", "Keyton Kinley", "Sarah Maras", "Abby Butler", "Sarah Sanders", "Kira Morikawa", "Sabrina Simms", "Tyler Alcorn", "Grace Talpash", "Aysia Harty", "Guewe Diouf", "Rylie Gregston"};

            Console.WriteLine("OU Women's Volleyball Team Roster:");

            //foreach loop to run through every item in list, "string player" is a new variable created to name each item in the list
            foreach (string player in wVBRoster)
            {
                count++;
                Console.WriteLine($"Player {count}: {player}");
            }

            Console.ReadKey();
        }
    }
}
