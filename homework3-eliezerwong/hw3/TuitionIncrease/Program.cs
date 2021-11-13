//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace TuitionIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Tuition Increase ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Console.WriteLine("Your tuition in the next 7 years is as follows");

            double tuition = 12000;
            double tuitionInc = 0.05;
            int year = 1;

            for (int i = year; i <= 7; i++)
            {
                tuition = tuition * (1 + tuitionInc);
                Console.WriteLine($"The tuition after year {i} will be {(tuition):C0}");
            }

            Console.ReadKey();
        }
    }
}
