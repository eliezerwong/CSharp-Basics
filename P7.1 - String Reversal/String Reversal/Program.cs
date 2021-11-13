//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- String Reversal ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Console.WriteLine("What is your favorite word?");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine("\n\rReversed is: ");

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(input[i]);
                }
                else
                {
                    Console.Write(input[i] + "*");
                }
                
            }

            Console.ReadKey();
        }
    }
}
