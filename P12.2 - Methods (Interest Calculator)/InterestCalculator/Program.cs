//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace InterestCalculator
{
    /*
    1. Call a function to display the header
    2. Take only validated inputs(use a function to validate)  from the user for a starting balance (local double variable), the number of years to run (local int variable), and the interest rate (global double variable)
    3. Pass your local variables as parameters to a void function that uses a loop to output to the console with the balance each year
    */
    class Program
    {
        static double GlobalVar;

        static void Main(string[] args)
        {
            DisplayHeader();

            Console.WriteLine("Enter starting balance:");
            double Bal = ValidateNum(Console.ReadLine());

            Console.WriteLine("Enter years to run:");
            int yearsRun = Convert.ToInt32(ValidateNum(Console.ReadLine()));

            Console.WriteLine("Enter interest rate:");
            Program.GlobalVar = ValidateNum(Console.ReadLine());

            Output(Bal, yearsRun, GlobalVar);

            Console.ReadKey();
        }

        static void DisplayHeader()
        {
            string title = "--- Interest Calculator";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);
        }

        static double ValidateNum (string input)
        {
            bool isNum = false;
            double startBal = 0;
            do
            {
                isNum = double.TryParse(input, out startBal);
            } while (!isNum);
            return startBal;
        }

        static void Output(double Bal, int yearsRun, double globalVar)
        {
            for (int i = 0; i < yearsRun; i++)
            {
                Bal += (Bal * globalVar);
                Console.WriteLine($"Year {i + 1}, account balance: {Bal}");
            }
        }
    }
}
