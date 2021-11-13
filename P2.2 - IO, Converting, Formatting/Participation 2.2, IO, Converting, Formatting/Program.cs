//Eliezer Emmanuel Wong
// MIS 3013-995

using System;

namespace Participation_2._2__IO__Converting__Formatting
{
    /* Requirements
    1. A comment before the main method letting me know what the code should do
    2. Asks the user's name, then takes what the user types and save it in a string variable
    3. Asks how many hours the user is taking, and convert it to an int
    4. Ask for a favorite number, save that value in a variable after converting it (don't forget to account for a favorite number like Pi and round to two decimal places). Then take the variable and use format specifier ("N2").
    5. Using string interpolation or the arguments method output a sentence asking if the information is all correct
    6. Make sure the program stops without closing */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Inputs, Outputs, Converting, Formatting --\n\r");

            Console.WriteLine("What is your name?\r");
            string userName = Console.ReadLine();
            // console inputs will be assigned as "UserName"
            Console.WriteLine("\r");

            Console.WriteLine("How many hours are you taking this semester?\r");
            int semHours = Convert.ToInt32(Console.ReadLine());
            // convert console inputs to Int32 and assign as "semHours"
            Console.WriteLine("\r");

            Console.WriteLine("What is your favorite number?\r");
            double favNum = Convert.ToDouble(Console.ReadLine());
            //convert console inputs to double and assign as "favNum"
            string formatFavNum = favNum.ToString("N2");
            //convert "favNum" to string formatted "N2" and assign as "formatFavNum"
            Console.WriteLine("\r");

            Console.WriteLine("<Hit enter to confirm>\nYour name is: {0}\nYou are taking: {1} hours\nYour favorite number is (rounded to two decimal places): {2} ", userName, semHours, formatFavNum);
            //arguments method

            /* string interpolation
            Console.WriteLine($"<Hit enter to confirm>\nYour name is: {userName}\nYou are taking: {semHours}\nYour favorite number is: {formatFavNum}");*/

            Console.ReadKey();
        }
    }
}
