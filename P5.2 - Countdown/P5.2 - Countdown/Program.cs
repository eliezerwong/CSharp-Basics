//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace P5._2___Countdown
{
    class Program
    {
        /*
        1. Ask the user to provide input for what number they want to count down by
        2. Ask the user to provide input for a number to count down from  (e.g. I wish to count down from 10 by 3)
        3. If a number was not entered,  use a loop to give an appropriate message and the opportunity to enter a number again
        4. Use the count down by and the count down from numbers and output to the console each time they divide evenly 
        */
        static void Main(string[] args)
        {
            string title = "--- Countdown ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            bool isNumber = false;
            int countBy = 0;

            //1.
            while (!isNumber)
            {
                Console.WriteLine("What number would you like to count down by?");
                isNumber = Int32.TryParse(Console.ReadLine(), out countBy);
            }

            isNumber = false;
            int countFrom = 0;

            while(!isNumber)
            {
                Console.WriteLine("What number would you like to count down from?");
                isNumber = Int32.TryParse(Console.ReadLine(), out countFrom);
            }

            int counter = 1;

            while (countFrom > counter)
            {
                if (counter % countBy == 0)
                {
                    Console.WriteLine(countFrom - counter);
                }
                counter++;
            }


            /*
            for (int i = 1; i < countFrom; i++)
            {
                if (i % countBy == 0)
                {
                    Console.WriteLine(countFrom - i);
                }
            }
            */
           

            Console.ReadKey();
        }
    }
}
