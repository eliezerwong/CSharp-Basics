//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace Class_Grades_Collection
{
    /*
    1. Create parallel arrays, one will have the course subject (e.g. MIS, MATH, etc.) and the other will hold course numbers (e.g. 3033, 3013, etc.). 
    2. Ask the user to input 3 for each, store them in the arrays.  Then output the results to the user concatenated together (e.g. MIS3033, MATH3013).
    3. Create a list for each class to hold grades for each class.
    4. Keep prompting the user if they have another grade to enter until they say 'no'. 
    5. Once you have all of the inputs, iterate through the list and calculate the average. 
    6. Output the average for each class
    */

    class Program
    {
        static void Main(string[] args)
        {
            string title = "--- Class Grades Collection ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            //parallel array, create a new string cSubj and cCode with 3 entries
            string[] cSubj = new string[3];
            string[] cCode = new string[3];
            
            //vars
            int i = 0;
            int counter = 1;
            double[] avgGrade = new double[3];

            //while counter i is less than specified length of cSubj (3), run for loop
            for (i = 0; i < cSubj.Length; i++)
            {
                //save input in array
                Console.WriteLine($"Course {i + 1} subject: ");
                cSubj[i] = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine($"Course {i + 1} number: ");
                cCode[i] = Console.ReadLine().Trim().ToUpper();
            }

            //output concatonated cSubj and cCode 
            for (i = 0; i < cSubj.Length; i++)
            {
                if (i != 2)
                {
                    Console.Write($"{cSubj[i]}{cCode[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{cSubj[i]}{cCode[i]}.");
                }
            }

            //create double list to store grades
            List<double> classGrades = new List<double>();
         
            //1st for loop to run the 3 input cSubj
            for(i = 0; i < cSubj.Length; i ++)
            {
                bool isNum = false;
                double grades;
                char userInput = 'Y';

                //do loop to ask for 1st grade & TryParse
                do
                {
                    Console.WriteLine($"\n\rWhat is your grade for {cSubj[i]}{cCode[i]}?");
                    isNum = double.TryParse(Console.ReadLine(), out grades);
                } while (!isNum);
                
                //step into additional grades loop, userInput = 'Y', also keeps asking if user has more grades until 'N' is input
                do
                {
                    Console.WriteLine("Do you have another grade to add? Y/N");
                    userInput = Convert.ToChar(Console.ReadLine().ToUpper());

                    //asks for the grades and save it to total grades
                    if (userInput == 'Y')
                    {
                        do
                        {
                            Console.WriteLine($"What other grades do you have for {cSubj[i]}{cCode[i]}?");
                            isNum = double.TryParse(Console.ReadLine(), out double addGrades);
                            //use addGrades instead of grades += grades bc will overwrite first 'grades' entered before the loop 
                            grades += addGrades;
                        } while (!isNum);
                        //counter out of TryParse so it doesnt count incorrect inputs, counter used as divisor to find average grade
                        counter++;
                    }
                } while (userInput == 'Y');
                //add(grades) replaces the last entry to the list
                classGrades.Add(grades);
                avgGrade[i] = classGrades[i] / counter;
                //reset counter for next cSubj
                counter = 1;
            }

            //output the calculated average grades
            for (i = 0; i < cSubj.Length; i++)
            {
                Console.WriteLine($"The average grade for {cSubj[i]}{cCode[i]} is {avgGrade[i]}");
            }

            Console.ReadKey();
        }
    }
}
