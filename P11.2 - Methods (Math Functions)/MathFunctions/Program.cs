//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of calculation would you like to peform? eg. add, subtract, multiply, divide."); 
            string userChoice = Console.ReadLine();

            string askVal1 = "Enter the first value:";
            string askVal2 = "Enter the second value:";

            bool isNum = false;
            double val1 = 0;
            double val2 = 0;
            do
            {
                Console.WriteLine(askVal1);
                isNum = double.TryParse(Console.ReadLine(), out val1);
            } while (!isNum);

            isNum = false;
            do
            {
                Console.WriteLine(askVal2);
                isNum = double.TryParse(Console.ReadLine(), out val2);
            } while (!isNum);
            

            if (userChoice == "add")
            {
                double addResult = Add(val1, val2);
                Console.WriteLine($"{val1} + {val2} = {addResult}");
                val1 = addResult;
            }
            else if (userChoice == "subtract")
            {
                double subtractResult = Subtract(val1, val2);
                Console.WriteLine($"{val1} + {val2} = {subtractResult}");
                val1 = subtractResult;
            }
            else if (userChoice == "multiply")
            {
                double multiplyResult = Multiply(val1, val2);
                Console.WriteLine($"{val1} * {val2} = {multiplyResult}");
                val1 = multiplyResult;
            }
            else if (userChoice == "divide")
            {
                double divideResult = Divide(val1, val2);
                Console.WriteLine($"{val1} / {val2} = {divideResult}");
                val1 = divideResult;
            }

            string anotherCalc = "new";

            while (anotherCalc == "new" || anotherCalc == "use")
            {
                Console.WriteLine("Would you like to perform another new calculation, use the result as the new first value, or stop? (new / use / stop)");
                anotherCalc = Console.ReadLine().ToLower();

                if (anotherCalc == "new")
                {
                    Console.WriteLine("What type of calculation would you like to peform? eg. add, subtract, multiply, divide.");
                    userChoice = Console.ReadLine();

                    isNum = false;
                    do
                    {
                        Console.WriteLine(askVal1);
                        isNum = double.TryParse(Console.ReadLine(), out val1);
                    } while (!isNum);

                    isNum = false;
                    do
                    {
                        Console.WriteLine(askVal2);
                        isNum = double.TryParse(Console.ReadLine(), out val2);
                    } while (!isNum);


                    if (userChoice == "add")
                    {
                        double addResult = Add(val1, val2);
                        Console.WriteLine($"{val1} + {val2} = {addResult}");
                        val1 = addResult;
                    }
                    else if (userChoice == "subtract")
                    {
                        double subtractResult = Subtract(val1, val2);
                        Console.WriteLine($"{val1} + {val2} = {subtractResult}");
                        val1 = subtractResult;
                    }
                    else if (userChoice == "multiply")
                    {
                        double multiplyResult = Multiply(val1, val2);
                        Console.WriteLine($"{val1} * {val2} = {multiplyResult}");
                        val1 = multiplyResult;
                    }
                    else if (userChoice == "divide")
                    {
                        double divideResult = Divide(val1, val2);
                        Console.WriteLine($"{val1} / {val2} = {divideResult}");
                        val1 = divideResult;
                    }
                }
                else if (anotherCalc == "use")
                {
                    Console.WriteLine("What type of calculation would you like to peform? eg. add, subtract, multiply, divide.");
                    userChoice = Console.ReadLine();

                    isNum = false;
                    do
                    {
                        Console.WriteLine(askVal2);
                        isNum = double.TryParse(Console.ReadLine(), out val2);
                    } while (!isNum);


                    if (userChoice == "add")
                    {
                        double addResult = Add(val1, val2);
                        Console.WriteLine($"{val1} + {val2} = {addResult}");
                        val1 = addResult;
                    }
                    else if (userChoice == "subtract")
                    {
                        double subtractResult = Subtract(val1, val2);
                        Console.WriteLine($"{val1} + {val2} = {subtractResult}");
                        val1 = subtractResult;
                    }
                    else if (userChoice == "multiply")
                    {
                        double multiplyResult = Multiply(val1, val2);
                        Console.WriteLine($"{val1} * {val2} = {multiplyResult}");
                        val1 = multiplyResult;
                    }
                    else if (userChoice == "divide")
                    {
                        double divideResult = Divide(val1, val2);
                        Console.WriteLine($"{val1} / {val2} = {divideResult}");
                        val1 = divideResult;
                    }
                }
                else if (anotherCalc == "stop")
                {
                    Console.WriteLine("Thanks for using the calculator");
                }
            }
            

            Console.ReadLine();
        }

        static double Add(double val1, double val2)
        {
            
            return val1 + val2;
        }

        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        static double Divide(double val1, double val2)
        {
            if (val2 == 0)
            {
                bool isNum = false;
                Console.WriteLine("Cannot divide by 0");
                do
                {
                    Console.WriteLine("Enter a new second value");
                    //val2 gets saved but console outputs eg, 10 / 0 = 5. (value gets saved in main before running function)
                    isNum = double.TryParse(Console.ReadLine(), out val2);
                } while (!isNum);
            }
            return val1 / val2;
        }
    }
}
