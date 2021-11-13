//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace P5._1___Multiples
{
    /*
    1. Ask the user to provide input for what number they want to count by
    2. Ask the user to provide input for a number to count up to  (e.g. I wish to count by 3 up to 10)
    3. If a number was not entered,  use a loop to give an appropriate message and the opportunity to enter a number again
    4. Use the count by and the count up to numbers and output to the console each time they divide evenly 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //placing title in the center of console. (console width - title length)/2 to find midpt of console, cursor top to make sure it appears at the top 
            string title = "--- Multiples ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //Console.WriteLine("What number would you like to count by?");
            //bool isNumber = Int32.TryParse(Console.ReadLine(), out int countBy);
            
            bool isNumber = false;
                //DRY (dont repeat yourself), bool false to step into while loop
                //defined vars can only live within code block, cannot be used outside. Hence, define first.
            int countBy = 0;

            while (!isNumber)
                //while bool == F (eg, is not number), while loop will keep running
            {
                Console.WriteLine("What number would you like to count by?");
                isNumber = Int32.TryParse(Console.ReadLine(), out countBy);
            }

            isNumber = false;
                //reset isNumber to false to step into next loop
            int upTo = 0;

            while (!isNumber)
            {
                Console.WriteLine("What number would you like to count up to?");
                isNumber = Int32.TryParse(Console.ReadLine(), out upTo); 
            }

            /*int counter = 1;

            while (counter < upTo)
            {
                if(counter % countBy == 0)
                {
                    Console.WriteLine(counter);
                }
                
                counter++;
            }
            */
           
            for (int i = 1; i < upTo; i++)
            {
                if (i % countBy == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
