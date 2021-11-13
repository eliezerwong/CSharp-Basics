//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace GetDoubleInput___Function
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Enter a number to be multipled by 5";
            double userInput = GetDoubleInput(message);
            Console.WriteLine($"{userInput} * 5 = {userInput * 5}");
            Console.ReadKey();
        }

        static double GetDoubleInput (string messageToUser)
        {
            bool isNum = false;
            double userInput = 0;

            do
            {
                Console.WriteLine(messageToUser);
                isNum = double.TryParse(Console.ReadLine(), out userInput);
            } while (!isNum);

            return userInput;
           
        }
    }
}
