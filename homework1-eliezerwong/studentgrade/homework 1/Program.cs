//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace StudentGrade
{
    /*
    1. Prompt the user to enter their first name, their last name, their student id number as well as their overall percentage grade for quizzes, participations, homeworks, midterm and final exam. 
    2. Use the weighted percentages on the syllabus for this class to calculate their final grade and output it as a percent.
     */
    class Program
    {
        const double hC = 0.25;
        const double pC = 0.1;
        const double qC = 0.1;
        const double mC = 0.25;
        const double fC = 0.3;

        static void Main(string[] args)
        {
            Console.WriteLine("--- StudentGrade ---");

            //1.
            Console.WriteLine("What is your first name?");
            string firstN = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string lastN = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            int idNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double hG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?");
            double pG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double qG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double mG = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double fG = Convert.ToDouble(Console.ReadLine());

            //2.
            double finalG = (hG*hC) + (pG*pC) + (qG*qC) + (mG*mC) + (fG*fC); 
            Console.WriteLine($"{firstN} {lastN} ({idNum}), your final grade is {(finalG/100):P2}.\n\r");

            Console.WriteLine("Press any key to continue . . .");

            Console.ReadKey();
        }
    }
}
