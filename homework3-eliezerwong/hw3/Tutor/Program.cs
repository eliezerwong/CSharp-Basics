//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Tutor ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Random random = new Random();
            int ran1 = random.Next(1, 50);
            int ran2 = random.Next(1, 50);

            Console.WriteLine($"{ran1} + {ran2} = ?");
            Int32.TryParse(Console.ReadLine(), out int userAns);

            do
            {

                if (userAns != (ran1 + ran2))
                {

                    Console.WriteLine("Sorry, your answer is incorrect. Please try again");
                    Int32.TryParse(Console.ReadLine(), out userAns);
                }
                /*else
                {
                    Console.WriteLine("Congratulations, your answer is correct");
                }
                */

            } while (userAns != (ran1 + ran2));
            //once the while statement is false, the do while doesnt run anymore. hence will not show "Congrats" if wrong > right

            Console.WriteLine("Congratulations, your answer is correct");

            Console.ReadKey();
        }
    }
}
