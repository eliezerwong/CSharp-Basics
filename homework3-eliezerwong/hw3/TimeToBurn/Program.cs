//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace TimeToBurn
{
    class Program
    {
        //const double burnCal = 3.9;

        static void Main(string[] args)
        {
            string title = "--- Time To Burn ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Console.WriteLine("How many calories do you wish to burn in this workout session?");
            Int32.TryParse(Console.ReadLine(), out int goalCal);

            double burnCal = 3.9;
            double currentBurn = 0;
            int timeMins = 1;

            while (currentBurn <= goalCal)
            {
                Console.WriteLine($"It has been {timeMins++} minutes since you began, your total calories burnt is {(currentBurn += burnCal):N1}");
            }

            Console.ReadKey();
        }
    }
}
