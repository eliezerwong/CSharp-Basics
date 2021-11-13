//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Threading;

namespace P4._2__Do_Loop
{
    /*
    1.  Use the compounding interest slide as a guide
    2. Take inputs from the user for a starting balance, the number of years to run, and the interest rate
    3. Check all number inputs to verify they are numbers and ask a second time if they do not enter a number the first time
    4. If a number was not entered, give an appropriate message then end the program.
    5. Use a While or a Do While loop to run and output to the console with the balance each year
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Interest Calculator ---\n\r");
            Console.WriteLine("This program will give you your projected account balance\n");
            
            Console.WriteLine("What is your current balance?");
            bool balIsNumber = Double.TryParse(Console.ReadLine(), out double cBal);
            if (balIsNumber)
            {

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
            
            Console.WriteLine("How many years will it be compounded?");
            bool yearIsNumber = Int32.TryParse(Console.ReadLine(), out int yCom);
            if (yearIsNumber)
            {

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }

            Console.WriteLine("What is the interest rate?");
            bool iIsNum = Double.TryParse(Console.ReadLine(), out double iRate);
            if (iIsNum)
            {

            }
            else
            {
                Console.WriteLine("Please enter a number");
            }

            int year = 0;
            do
            {
                Console.WriteLine($"The balance is {(cBal * Math.Pow(iRate, ++year)):C2}");
            } while (year < yCom);


                Console.ReadKey();
        }
    }
}
