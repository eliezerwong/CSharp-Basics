//Eliezer Emmanuel Wong
//MIS 3013-995 
using System;

namespace P3._2__If_Statements

/*
1. Ask the user what they are counting
2. Ask how many of that item they have and use the If Statement to output different messages based on the numbers
3. Come up with your own messages 
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- If Statements ---\n\r");

            // 1.
            Console.WriteLine("What are we counting?");
            string countingItem = Console.ReadLine();

            // 2.
            Console.WriteLine($"How many {countingItem} do we have?");
            int countNum = Convert.ToInt32(Console.ReadLine());

            if (countNum == 1)
            {
                Console.WriteLine("You only have 1? You need more!");
            }
            else if (countNum == 2)
            {
                Console.WriteLine("2 is alright");
            }
            else if (countNum == 3 || countNum == 4)
            {
                Console.WriteLine("That's a bunch");
            }
            else
            {
                Console.WriteLine("What were you even thinking?");
            }

            Console.ReadKey();
        }
    }
}
