//Eliezer Emmanuel Wong
//MIS3013-995
using System;

namespace Homework4._1
{
    /*
    1.  Prompt the user to pick a number from 1 to 10.
    2. Use TryParse to make sure they enter a number.
    3. If a number was entered, create a random number using the random class, then check if they guess correctly. If not give them a second chance. Output appropriate message.
    4. If a number was not entered, give an appropriate message then end the program.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Random Class ---\n\r");
            Console.WriteLine("Pick a number between 1 and 10");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int userguess);

            if (isNumber)
            {
                Random random = new Random();
                int randomNum = random.Next(1,10);

                if (userguess == randomNum)
                {
                    Console.WriteLine($"Great guess! {userguess} was correct!");
                }   
                    else
                {
                    Console.WriteLine("You get one more try");
                    Console.WriteLine("Pick a number between 1 and 10");
                    isNumber = Int32.TryParse(Console.ReadLine(), out userguess);

                    if (userguess == randomNum)
                    {
                        Console.WriteLine($"Great Guess! {userguess} was correct!");
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing! Sorry you didn't guess correctly");
                    }
                }
              
            }
            else 
            {
                Console.WriteLine("Sorry, that was not what was asked for");
            }
            Console.ReadKey();

        }
    }
}
