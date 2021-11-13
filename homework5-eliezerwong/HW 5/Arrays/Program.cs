//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Arrays ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            bool isNum = false;
            int namesCount;
            int i;

            //TryParse number of student names user wants to store
            do
            {
                Console.WriteLine("How many student names would you like to store?");
                isNum = Int32.TryParse(Console.ReadLine(), out namesCount);
            } while (!isNum);

            //Console.WriteLine(namesCount);

            //create new parallel string arrays with the size of namesCount
            string[] fName = new string[namesCount];
            string[] lName = new string[namesCount];

            //store fName, lName
            for (i = 0; i < namesCount; i++)
            {
                Console.WriteLine($"Enter first name for student {i + 1}");
                fName[i] = Console.ReadLine();
                Console.WriteLine($"Enter last name for student {i + 1}");
                lName[i] = Console.ReadLine();
            }

            //Console.WriteLine(i);

            //output lName, fName
            Console.WriteLine("Here are the students' names:");
            for (i = 0; i < fName.Length; i++)
            {
                Console.WriteLine($"{lName[i].Trim()}, {fName[i].Trim()}");
            }

            Console.ReadKey();
        }
    }
}
