//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace TopEarners
{
    class Program
    {
        /*
        1. Create parallel arrays, one will have salespeople first names and the other will hold last names. 
        2. Ask the user to input 3 for each, store them in the arrays. 
        3. Ask the user for each salesperson's ID (int), and put their name and ID into a dictionary.
        4. Use a foreach loop of the dictionary and ask the user to input the yearly earnings of each  salesperson that will be saved in a list
        5. Then use a foreach loop  through the list to calculate the total earned between all of the salespeople, then output the average of those salespeople earnings.
        */
        static void Main(string[] args)
        {
            string title = "--- Top Earners ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            string[] firstName = new string[3];
            string[] lastName = new string[3];
            Dictionary<int, string> salesPeople = new Dictionary<int, string>();

            Console.WriteLine("The top three earners in the company are:");
            for (int i = 0; i <= firstName.Length; i++)
            {
                Console.WriteLine($"Salesperson {i+1} first name:");
                firstName[i] = Console.ReadLine().Trim();
                Console.WriteLine($"Salesperson {i+1} last name:");
                lastName[i] = Console.ReadLine();
            }

            for (int i = 0; i <= firstName.Length; i++)
            {
                bool isNum = false;
                int idNum;
                do
                {
                    Console.WriteLine($"What is {firstName[i]} {lastName[i]}'s ID number:");
                    isNum = Int32.TryParse(Console.ReadLine(), out idNum);
                } while (!isNum);
                salesPeople.Add(idNum, firstName[i] + lastName[i]);
            }

            List<double> yearEarnings = new List<double>();
            foreach (var person in salesPeople)
            {
                bool isNum = false;
                double earnings;
                do
                {
                    Console.WriteLine($"What is {person.Value}'s earnings this year?");
                    isNum = double.TryParse(Console.ReadLine(), out earnings);
                } while (!isNum);
                yearEarnings.Add(earnings);
            }

            double sum = 0;
            foreach (double earning in yearEarnings)
            {
                sum += earning;
            }

            Console.WriteLine($"Average earnings between these 3 salespeople is {sum / yearEarnings.Count:c2}");

            Console.ReadKey();
        }
    }
}
