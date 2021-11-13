//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace SumOf3
{
    class Program
    {
        /*
        1. Call a method to display the header
        2. Set a global variable (validate a number was entered)
        3. Prompt the user to enter 3 different numbers(1 is a valid input and so is 5.5) and put them in a list
        4. Call a method to add all 3 numbers together and output the result displaying 2 decimal places
        5. Calculate a second value, where you multiply the sum of the 3 numbers by a the global variable
        */

        static double GlobalVar;

        static void Main(string[] args)
        {
            DisplayHeader();

            Console.WriteLine("Set a global variable:");
            Program.GlobalVar = ValidateNum(Console.ReadLine());

            List<double> numbers = new List<double>();

            Console.WriteLine("Please enter a number:");
            numbers.Add(ValidateNum(Console.ReadLine()));

            Console.WriteLine("Enter 2nd number:");
            numbers.Add(ValidateNum(Console.ReadLine()));

            Console.WriteLine("Enter 3rd number");
            numbers.Add(ValidateNum(Console.ReadLine()));

            //double sum = Sum(numbers);
            Console.WriteLine($"The sum of numbers are {Sum(numbers):n2}");
            Console.WriteLine($"The sum multiplied by the constant {GlobalVar} is {(GlobalVar * Sum(numbers)):n2}");
            
            Console.ReadKey();
        }

        static double Sum(List<double> numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        static double ValidateNum(string input)
        {
            bool isNum = false;
            double validNum;
            do
            {
                isNum = double.TryParse(input, out validNum);

                if (!isNum)
                {
                    Console.WriteLine("Please enter a valid number");
                }

            } while (!isNum);

            return validNum;
        }

        static void DisplayHeader()
        {
            string title = "--- Sum of 3 ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }
    }
}
