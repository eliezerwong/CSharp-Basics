//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Monogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Monogram ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //user input
            Console.WriteLine("Enter your first name");
            //remove whitespace, all to caps, & take only first letter
            string fName = Console.ReadLine().ToUpper().Trim().Substring(0,1);
            //convert to char
            char fNI = Convert.ToChar(fName);

            Console.WriteLine("Enter your middle name");
            string mName = Console.ReadLine().ToUpper().Trim().Substring(0,1);
            char mNI = Convert.ToChar(mName);
            
            Console.WriteLine("Enter your last name");
            string lName = Console.ReadLine().ToUpper().Trim().Substring(0,1);
            char lNI = Convert.ToChar(lName);

            //output with "." after each letter
            Console.WriteLine($"Your monogram is {fNI}.{mNI}.{lNI}.");

            Console.ReadKey();
        }
    }
}
