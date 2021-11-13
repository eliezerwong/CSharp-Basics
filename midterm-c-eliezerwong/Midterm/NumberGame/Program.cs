//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Number Game ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //variables & create random class
            Random random = new Random();
            int randomNum = random.Next(1, 100);
            Console.WriteLine(randomNum);

            //to step into loop
            int userGuess = 0;
            bool isNum = false;
            int posGuessDiff = userGuess - randomNum;
            int negGuessDiff = randomNum - userGuess;
            int counter = 1;
            
            //keep guessing as long as not right
            while (userGuess != randomNum)
            {
                //ensure userinput is number & within bounds
                do
                {
                    do
                    {
                        Console.WriteLine("Pick a number between 1 and 100");
                        isNum = Int32.TryParse(Console.ReadLine(), out userGuess);
                    } while (!isNum);
                } while (userGuess < 1 || userGuess > 100);

                //5 feedbacks
                if ((userGuess > randomNum) && (posGuessDiff <= 10))
                {
                    Console.WriteLine("A little high, but so close");
                }
                else if ((userGuess > randomNum) && (posGuessDiff > 10))
                {
                    Console.WriteLine("Too high! Guess again");
                }
                else if ((userGuess < randomNum) && (negGuessDiff <= 10))
                {
                    Console.WriteLine("A little low, but so close");
                }
                else if ((userGuess < randomNum) && (negGuessDiff > 10))
                {
                    Console.WriteLine("Too low! Guess again");
                }
                else
                {
                    Console.WriteLine($"You guessed the number in {counter} guesses!!");
                }
                //counter to count number of guesses
                counter++;
            }


            Console.ReadKey();
        }
    }
}
