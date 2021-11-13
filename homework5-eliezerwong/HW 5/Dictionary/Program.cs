//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;
using System.Xml.Xsl;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Dictionary ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //Create dictionary "foods" with categories as string and values as list
            Dictionary<string, List<string>> foods = new Dictionary<string, List<string>>();

            //Create lists and input foods
            List<string> entryFruit = new List<string>() { "Apples", "Oranges", "Strawberries" };
            List<string> entryVeg = new List<string>() { "Carrots", "Peas", "Onions" };
            List<string> entryDessert = new List<string>() { "Flan", "Cake", "IceCream" };

            //Add string as category and list as entries to dictionary
            foods.Add("Fruits", entryFruit);
            foods.Add("Vegetables", entryVeg);
            foods.Add("Desserts", entryDessert); 
            
            //Output items in dictionary
            foreach (var typeFood in foods)
            {
                    Console.WriteLine($"{typeFood}, {foods.Values}");
            }

            Console.WriteLine("Would you like to enter a new category or new food item? (Y/N)");
            char userAns = Convert.ToChar(Console.ReadLine().ToUpper());

            string userCat = null;

            while (userAns != 'N')
            {
                Console.WriteLine("Do you want to enter a category or food?");
                string catOrFood = Console.ReadLine();

                if(catOrFood == "category")
                {
                    Console.WriteLine("What category would you like to add?");
                    userCat = Console.ReadLine();
                    foods.Add(userCat, new List<string>());
                }
                else
                {
                    Console.WriteLine("Which category would you like to add a new food item to?");
                    string foodCatAdd = Console.ReadLine().Trim().ToUpper();
                    if (foodCatAdd == "FRUITS")
                    {
                        Console.WriteLine("What fruit would you like to add?");
                        string fruitAdd = Console.ReadLine();
                        entryFruit.Add(fruitAdd);
                    }
                    else if (foodCatAdd == "VEGETABLES")
                    {
                        Console.WriteLine("What vegetable would you like to add?");
                        string vegAdd = Console.ReadLine();
                        entryVeg.Add(vegAdd);
                    }
                    else if (foodCatAdd == "DESSERTS")
                    {
                        Console.WriteLine("What dessert would you like to add?");
                        string dessertAdd = Console.ReadLine();
                        entryDessert.Add(dessertAdd);
                    }
                    else
                    {
                        Console.WriteLine($"What food would you like to add to {foodCatAdd}?");
                        string catAdd = Console.ReadLine();
                        foods[userCat].Add(catAdd);
                    }
                }
                Console.WriteLine("Would you like to add another new category or food item? (Y/N)");
                userAns = Convert.ToChar(Console.ReadLine().ToUpper());
            }

            int count = 1;

            Console.WriteLine("Pick a category to see all food items:");
            foreach (var typeFood in foods)
            {
                Console.WriteLine($"{count}) {typeFood}");
                count++;
            }
            string catPick = Console.ReadLine();
            foreach (var typeFood in foods)
            {
                string typeFood1 = Convert.ToString(typeFood);
                while (typeFood1 == catPick)
                {
                    Console.WriteLine($"{typeFood}, {foods.Values}");
                }
            }

            Console.ReadKey();
        }
    }
}
