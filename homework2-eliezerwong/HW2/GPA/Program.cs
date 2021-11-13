//Eliezer Emmanuel Wong
//MIS 3013-995
using System;

namespace GPA
{
    class Program
    {
        const int creditHr = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("--- GPA ---\n\r");

            Console.WriteLine("What is your grade percentage for Accounting?");
            double accGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your grade percentage for Marketing?");
            double marGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your grade percentage for Economics?");
            double ecoGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your grade percentage for MIS?");
            double misGrade = Convert.ToDouble(Console.ReadLine());

            //Declare Variable types (cannot be used outside of IF statements if declared there)
            int accGP;
            int marGP;
            int ecoGP;
            int misGP;

            //Accounting Grade
            if (accGrade >= 90)
            {
                char accLetterGrade = 'A';
                accGP = creditHr * 4;
                Console.WriteLine($"\tAccounting Grade: {accLetterGrade}, Grade Points: {accGP}");
            }
            else if (accGrade >= 80)
            {
                char accLetterGrade = 'B';
                accGP = creditHr * 3;
                Console.WriteLine($"\tAccounting Grade: {accLetterGrade}, Grade Points: {accGP}");
            }
            else if (accGrade >= 70)
            {
                char accLetterGrade = 'C';
                accGP = creditHr * 2;
                Console.WriteLine($"\tAccounting Grade: {accLetterGrade}, Grade Points: {accGP}");
            }
            else if (accGrade >= 60)
            {
                char accLetterGrade = 'D';
                accGP = creditHr * 1;
                Console.WriteLine($"\tAccounting Grade: {accLetterGrade}, Grade Points: {accGP}");
            }
            else
            {
                char accLetterGrade = 'F';
                accGP = creditHr * 0;
                Console.WriteLine($"\tAccounting Grade: {accLetterGrade}, Grade Points: {accGP}");
            }

            
            //Marketing Grade
            if (marGrade >= 90)
            {
                char marLetterGrade = 'A';
                marGP = creditHr * 4;
                Console.WriteLine($"\tMarketing Grade: {marLetterGrade}, Grade Points: {marGP}");
            }
            else if (marGrade >= 80)
            {
                char marLetterGrade = 'B';
                marGP = creditHr * 3;
                Console.WriteLine($"\tMarketing Grade: {marLetterGrade}, Grade Points: {marGP}");
            }
            else if (marGrade >= 70)
            {
                char marLetterGrade = 'C';
                marGP = creditHr * 2;
                Console.WriteLine($"\tMarketing Grade: {marLetterGrade}, Grade Points: {marGP}");
            }
            else if (marGrade >= 60)
            {
                char marLetterGrade = 'D';
                marGP = creditHr * 1;
                Console.WriteLine($"\tMarketing Grade: {marLetterGrade}, Grade Points: {marGP}");
            }
            else
            {
                char marLetterGrade = 'F';
                marGP = creditHr * 0;
                Console.WriteLine($"\tMarketing Grade: {marLetterGrade}, Grade Points: {marGP}");
            }


            //Economics Grade
            if (ecoGrade >= 90)
            {
                char ecoLetterGrade = 'A';
                ecoGP = creditHr * 4;
                Console.WriteLine($"\tEconomics Grade: {ecoLetterGrade}, Grade Points: {ecoGP}");
            }
            else if (ecoGrade >= 80)
            {
                char ecoLetterGrade = 'B';
                ecoGP = creditHr * 3;
                Console.WriteLine($"\tEconomics Grade: {ecoLetterGrade}, Grade Points: {ecoGP}");
            }
            else if (ecoGrade >= 70)
            {
                char ecoLetterGrade = 'C';
                ecoGP = creditHr * 2;
                Console.WriteLine($"\tEconomics Grade: {ecoLetterGrade}, Grade Points: {ecoGP}");
            }
            else if (ecoGrade >= 60)
            {
                char ecoLetterGrade = 'D';
                ecoGP = creditHr * 1;
                Console.WriteLine($"\tEconomics Grade: {ecoLetterGrade}, Grade Points: {ecoGP}");
            }
            else
            {
                char ecoLetterGrade = 'F';
                ecoGP = creditHr * 0;
                Console.WriteLine($"\tEconomics Grade: {ecoLetterGrade}, Grade Points: {ecoGP}");
            }


            //MIS Grade
            if (misGrade >= 90)
            {
                char misLetterGrade = 'A';
                misGP = creditHr * 4;
                Console.WriteLine($"\tMIS Grade: {misLetterGrade}, Grade Points: {misGP}");
            }
            else if (misGrade >= 80)
            {
                char misLetterGrade = 'B';
                misGP = creditHr * 3;
                Console.WriteLine($"\tMIS Grade: {misLetterGrade}, Grade Points: {misGP}");
            }
            else if (misGrade >= 70)
            {
                char misLetterGrade = 'C';
                misGP = creditHr * 2;
                Console.WriteLine($"\tMIS Grade: {misLetterGrade}, Grade Points: {misGP}");
            }
            else if (misGrade >= 60)
            {
                char misLetterGrade = 'D';
                misGP = creditHr * 1;
                Console.WriteLine($"\tMIS Grade: {misLetterGrade}, Grade Points: {misGP}");
            }
            else
            {
                char misLetterGrade = 'F';
                misGP = creditHr * 0;
                Console.WriteLine($"\tMIS Grade: {misLetterGrade}, Grade Points: {misGP}");
            }


            double totalGP = accGP + marGP + ecoGP + misGP;
            double totalCredit = creditHr * 4;
            double overallGPA = totalGP / totalCredit;

            Console.WriteLine($"\n\r\tOverall GPA: {overallGPA}");

            Console.ReadKey();
        }
    }
}
