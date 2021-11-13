//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace Shipping
{
    class Program
    {
        const double hazardUpCharge = 0.15;
        static void Main(string[] args)
        {
            Console.WriteLine("--- Shipping ---\n\r");

            Console.WriteLine("Enter total weight of shipping in pounds");
            double shipWeight = Convert.ToDouble(Console.ReadLine());
            //Double.TryParse(Console.ReadLine(), out double shipWeight);

            Console.WriteLine("Enter distance in miles");
            Double.TryParse(Console.ReadLine(), out double shipDist);

            //Standardize specification
            Console.WriteLine("Are there hazardous materials in the shippment (e.g. batteries)? \nEnter as T / F");
            Char.TryParse(Console.ReadLine(), out char shiphazard);

            double quote = (0.55 * shipDist) + (0.73 * shipWeight);
            double hazardQuote = (0.55 * shipDist) + ((0.73 + 0.15) * shipWeight);

            if (shiphazard == 'T')
            {
                if (shipDist < 150 && shipWeight > 500)
                {
                    Console.WriteLine($"Origial Quote Calculation: {quote:C2}");
                    Console.WriteLine($"Extra cost if Hazardous: {(hazardUpCharge * shipWeight):C2}");
                    Console.WriteLine($"Discount: {(0.1 * hazardQuote):C2}");
                    Console.WriteLine($"The quoted total shipping cost is {(0.9 * hazardQuote):C2} for hazardous material with shiping discount");
                }
                else
                {
                    Console.WriteLine($"Origial Quote Calculation: {quote:C2}");
                    Console.WriteLine($"Extra cost if Hazardous: {(hazardUpCharge * shipWeight):C2}");
                    Console.WriteLine($"Discount: N/A");
                    Console.WriteLine($"The quoted total shipping cost is {hazardQuote:C2} for hazardous material");
                }
            }
            else
            {
                if (shipDist < 150 && shipWeight > 500)
                {
                    Console.WriteLine($"Origial Quote Calculation: {quote:C2}");
                    Console.WriteLine($"Extra cost if Hazardous: N/A");
                    Console.WriteLine($"Discount: {(0.1 * quote):C2}");
                    Console.WriteLine($"The quoted total shipping cost is {(0.9 * quote):C2} with shipping discount");
                }
                else
                {
                    Console.WriteLine($"Origial Quote Calculation: {quote:C2}");
                    Console.WriteLine($"Extra cost if Hazardous: N/A");
                    Console.WriteLine($"Discount: N/A");
                    Console.WriteLine($"The quoted total shipping cost is {quote:C2}");
                }
            }

            Console.ReadKey();
        }
    }
}
