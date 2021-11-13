//Eliezer Emmanuel Wong
//MIS 3013-995

using System;

namespace Participation_3._1___Sum_of_3_Numbers
{
    /*
    1.  Prompt the user to enter 3 different numbers (1 is a valid input and so is 5.5)
    2. Add all 3 numbers together and output the result displaying 3 decimal places. 
    3. Calculate a second value, where you multiply the sum of the 3 numbers by a constant value of 7.777 (hint: make a constant variable that is type double).
    */

    class Program
    {
        const double constant = 7.777;
        // constant defined inside class but outside main method
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sum of 3 Numbers ---\n\r");

            // 1.
            Console.WriteLine("Please enter a number >>>");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r");

            Console.WriteLine("Please enter another number >>>");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r");

            Console.WriteLine("Please enter a final number >>>");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\r");

            // 2.
            double sum = num1 + num2 + num3;
            Console.WriteLine($"The sum of those numbers are {sum:N2}\n\r");
            // sum:N2 is the same as sum.ToString("N2") but it only works on string interpolation
            //standard concatenation: Console.WriteLine("The sum of those numbers are " + (num1 + num2 + num3));

            // 3.
            Console.WriteLine($"Those numbers multiplied by the constant {constant} is {(constant * sum):N2}");

            Console.ReadKey();
        }
    }
}
