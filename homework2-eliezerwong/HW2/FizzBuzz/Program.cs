//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- FizzBuzz ---\n\r");

            //ask for input & TryParse to bool for IF
            Console.WriteLine("Please enter your lucky number >>>");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int userGuess);

            if (isNumber)
            {
                //IF isNumber == T, nestedIF runs
                if (userGuess % 3 == 0 && userGuess % 5 == 0)
                //remainder of userGuess after / by 3 and 5 == 0
                {
                    Console.WriteLine($"{userGuess} FizzBuzz");
                }
                else if (userGuess % 3 == 0)
                {
                    Console.WriteLine($"{userGuess} Fizz");
                }
                else if (userGuess % 5 == 0)
                {
                    Console.WriteLine($"{userGuess} Buzz");
                }
                else
                {
                    Console.WriteLine($"{userGuess}");
                }
            }
            else
            {
                Console.WriteLine("Sorry, the input was not a valid number and FizzBuzz could not be run");
            }


            Console.ReadKey();
        }
    }
}
