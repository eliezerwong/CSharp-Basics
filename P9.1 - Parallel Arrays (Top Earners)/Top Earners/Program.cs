//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace Top_Earners
{
    /*
    1. Create parallel arrays, one will have salespeople first names and the other will hold last names. 
    2. Ask the user to input 3 for each, store them in the arrays. 
    3. Then create a list to hold the yearly earnings of that each salesperson, and ask the user to input each of those amounts
    4. Then output the average of those salespeople earnings. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Top Earners ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            string[] firstName = new string[3];
            string[] lastName = new string[3];

            Console.WriteLine("The top 3 earners in the company are: \n\r");
            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine($"Salesperson {i + 1} first name:");
                firstName[i] = Console.ReadLine().Trim();
                Console.WriteLine($"Salesperson {i + 1} last name:");
                lastName[i] = Console.ReadLine().Trim();
            }

            List<double> thisYearsEarnings = new List<double>();
            for (int i = 0; i < firstName.Length; i++)
            {
                bool isNum = false;
                double earning;
                do
                {
                    Console.WriteLine($"What are {firstName[i]} {lastName[i]}'s earnings this year?");
                    isNum = double.TryParse(Console.ReadLine(), out earning);
                } while (!isNum);

                thisYearsEarnings.Add(earning);
            }

            double sum = 0;
            for (int i = 0; i < thisYearsEarnings.Count; i++)
            {
                sum += thisYearsEarnings[i];
            }

            Console.WriteLine($"Average earnings between these 3 salespeople is {sum/3:C2}");

            Console.ReadKey();
        }
    }
}
