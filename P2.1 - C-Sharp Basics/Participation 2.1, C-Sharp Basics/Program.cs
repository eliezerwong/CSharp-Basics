//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Participation_2._1__C_Sharp_Basics
{
    /*This program will show that i know:
    1. What a "hard-coded" variable is
    2. How to use the different types of comments
    3. How to create variables of different types
    4. How to use escape sequences in a string
    5. How to output information to the console
    6. How to write a basic binary expression
    7. Three types of concatenation
    8. How to use number formant and precision specifiers
    9. How to make a program stop without closing*/

    //2. "//" for single line, "/* */" for multi-line
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hard coded variables
            //4. Escape sequence \n\r for new line and return
            string hardcoded = "-- C# Basics --\n\r";
            string myName = "Eliezer Emmanuel Wong";
            int classhours = 15;
            DateTime currentDateTime = DateTime.Now;

            //This will output the hard coded title
            Console.WriteLine(hardcoded);
            //7. String interpolation (concatenation), variable in string -- "string {var1} string {var2} string \escape"
            Console.WriteLine($"My name is {myName}, the current date and time is {currentDateTime}, and I am in {classhours} hours this semester\n\r");

            int firstInt = 1;
            int secInt = 5;

            //7. Standard concatenation
            Console.WriteLine("My favorite number is " + firstInt + " and my second favorite number is " + secInt + "\n\r");
            //                    <"string">          <+> <var1> <+>          <"string">               <+> <var2> <+> <escape>

            //6. Binary operation
            Console.WriteLine("We then use our binary operator firstInt '+=' secInt \n\r");
            firstInt += secInt;

            //8. Precision specifier
            string formattednumber = firstInt.ToString("D2");

            //7. Arguments method (concatenation)
            Console.WriteLine("This changes the firstInt value to {0} while secInt remains at {1}\n\r", firstInt, secInt);
            //                           <"string {0}, {1}, {2}, {...}">           , <var1 in {0}>, <var2>, <var3>, <var...>

            Console.WriteLine("And now the value of firstInt formatted to 2 digits is: {0}\n\rThis is equal to the original value of firstInt plus secInt", formattednumber);

            Console.ReadKey();
        }
    }
}
