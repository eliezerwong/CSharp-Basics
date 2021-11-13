//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace ClassGrades
{
    class Program
    {
        /*
        1. Create a dictionary, with the key being the course subject (e.g. MIS, MATH, etc.) and the value will hold the course numbers (e.g. 3033, 3013, etc.). 
        2. Ask the user to input 3, then using a foreach loop output the results to the user concatenated together (e.g. MIS3033, MATH3013).
        3. Create a list for each class to hold grades for each class.
        4. Keep prompting the user if they have another grade to enter until they say 'no'. 
        5. Once you have all of the inputs, iterate through the list with a foreach loop and calculate the average. 
        6. Output the average for each class
        */
        static void Main(string[] args)
        {
            string title = "--- Class Grades ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            Dictionary<string, int> courses = new Dictionary<string, int>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the course subject:");
                string cSubj = Console.ReadLine().Trim().ToUpper();

                bool isNum = false;
                int cNum = 0;
                do
                {
                    Console.WriteLine($"Enter the course number:");
                    isNum = Int32.TryParse(Console.ReadLine(), out  cNum);
                } while (!isNum);

                 courses.Add(cSubj, cNum);
            }

            foreach (var course in courses)
            {
                Console.Write($"{course.Key}{course.Value} ");
            }

            List<double> grades = new List<double>();
            
            foreach (var course in courses)
            {
                char enterGrade = 'Y';
                bool isNum = false;
                
                double sum = 0;
                double[] avgGrade = new double[3];

                int counter = 1;
                int j = 0;
                
                do
                {
                    Console.WriteLine($"\rWould you like to add a grade for {course}? (Y/N)");
                    enterGrade = Convert.ToChar(Console.ReadLine().ToUpper());
                    
                    if (enterGrade == 'Y')
                    {
                        double inputGrade;

                        do
                        {
                            Console.WriteLine($"What grade would you like to add to {course}?");
                            isNum = double.TryParse(Console.ReadLine(), out inputGrade);
                        } while (!isNum);

                        sum += inputGrade;
                        counter++;
                    }
                } while (enterGrade != 'N');
                
                avgGrade[j] = sum / counter;
                grades.Add(avgGrade[j]);
                counter = 1;
                j++;
            }

            //foreach is not a loop so it doesnt run the i++ like a for loop
            foreach (var course in courses)
            {
                int i = 0;
                Console.WriteLine($"{course.Key}{course.Value} average grade: {grades[i]}");
                i++;
            }

            Console.ReadKey();

            //should have done each list<double> seperately, do while loop each list<double>
        }
    }
}
