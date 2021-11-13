//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Tax_Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Tax Rate ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //prompt name
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            //do while loop tryparse salary
            bool isDouble = false;
            double userSalary = 0;
            do
            {
                Console.WriteLine("Enter your annual salary:");
                isDouble = double.TryParse(Console.ReadLine(), out userSalary);
            } while (!isDouble);

            //save returned method values
            //CalculateFederalTax(userSalary) displays what is returned at the end of the method. it takes var: userSalary and inputs it into the method for calculation
            //in the method static double CalculateFederalTax(double userSalary), this is the method where my parameter is type double varName (of whatever i input in main)
            double FedTax = CalculateFederalTax(userSalary);
            double FICATax = CalculateFICATax(userSalary);

            //output to console code from method
            DisplayResults(userName, userSalary, FedTax, FICATax);

            Console.ReadKey();
        }

        static double CalculateFederalTax(double userSalary)
        {
            double fedTax = 0;
            if (userSalary >= 500001)
            {
                fedTax = userSalary * 0.37;
            }
            else if (userSalary >= 200001)
            {
                fedTax = userSalary * 0.35;
            }
            else if (userSalary >= 157501)
            {
                fedTax = userSalary * 0.32;
            }
            else if (userSalary >= 82501)
            {
                fedTax = userSalary * 0.24;
            }
            else if (userSalary >= 38701)
            {
                fedTax = userSalary * 0.22;
            }
            else if (userSalary >= 9526)
            {
                fedTax = userSalary * 0.12;
            }
            else
            {
                fedTax = userSalary * 0.1;
            }

            return fedTax;
        }

        static double CalculateFICATax(double userSalary)
        {
            double FICATax = userSalary * 0.062;
            return FICATax;
        }

        static void DisplayResults(string val1, double val2, double val3, double val4)
        {
            Console.WriteLine($"{val1} earned {val2:C2}\nFederal Tax withheld: {val3:C2}\nFICA Tax withheld: {val4:C2}\nNet Salary: {(val2 - (val3 + val4)):C2}");
        }
    }
}
