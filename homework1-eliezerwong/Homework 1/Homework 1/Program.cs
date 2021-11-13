//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace SalesTotal
{   /*
    1. Prompt the user to enter what type of item they are purchasing
    2. Prompt the user to enter how many of <item>
    3. Prompt the user for the price of one item
    4. Calculate the subtotal, the sales tax and the sales total (subtotal + sales tax) and output all 3 to the user.  Assume that the sales tax for your application is 8.5% (create a constant to store this value and use the constant in your calculations).
     */
    class Program
    {
        const double tax = 0.085;
        static void Main(string[] args)
        {
            Console.WriteLine("--- SalesTotal ---\n\r");
            //1.
            Console.WriteLine("What is the name of the item you are purchasing?");
            string itemName = Console.ReadLine();
            //2.
            Console.WriteLine($"How many {itemName} do you want to buy?");
            int itemQuant = Convert.ToInt32(Console.ReadLine());
            //3.
            Console.WriteLine("What is the price for each {0}?", itemName);
            double itemPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n");
            //4.
            double subTotal = itemQuant * itemPrice;
            double salesTax = subTotal * tax;
            Console.WriteLine($"\tYour subtotal for your bill is {subTotal:C2}");
            Console.WriteLine($"\tYour sales tax for your bill is {salesTax:C2}");
            Console.WriteLine($"\tYour total for your bill is {(subTotal+salesTax):C2}\n\r");

            Console.WriteLine("Press any key to continue . . .");

            Console.ReadKey();
        }
    }
}
