//Eliezer Emmanuel Wong
//MIS 3013-995
using System;
using System.Collections.Generic;

namespace CalculateGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.FirstName = "Eli";
            student1.LastName = "Wong";
            student1.StudentID = 113452682;
            student1.ExamGrades = new List<double>() { 100, 98 };
            student1.FinalExamGrades = new List<double>() { 98, 97 };
            student1.HomeworkGrades = new List<double>() { 100, 100, 97, 96 };
            student1.ParticipationGrades = new List<double>() { 100, 100, 99, 98, 95 };
            student1.QuizGrades = new List<double>() { 100, 98, 99 };
            
            Console.WriteLine($"{student1.ToString()}");
            Console.WriteLine($"Exam Avg: {student1.CalcExamAvg()}\nFinal Exam Avg: {student1.CalcFinalExamAvg()}\nHomework Avg: {student1.CalcHWAvg()}\nParticipation Avg: {student1.CalcParticipationAvg()}\nQuiz Avg: {student1.CalcQuizAvg()}");

            Student student2 = new Student(113452683);
            student2.FirstName = "Kenny";
            student2.LastName = "Korn";
            student2.ExamGrades = new List<double>() { 99, 95 };
            student2.FinalExamGrades = new List<double>() { 95, 92 };
            student2.HomeworkGrades = new List<double>() { 99, 99, 95, 91 };
            student2.ParticipationGrades = new List<double>() { 100, 95, 96, 97, 98 };
            student2.QuizGrades = new List<double>() { 100, 95, 96 };

            Console.WriteLine($"{student2.ToString()}");
            Console.WriteLine($"Exam Avg: {student2.CalcExamAvg()}\nFinal Exam Avg: {student2.CalcFinalExamAvg()}\nHomework Avg: {student2.CalcHWAvg()}\nParticipation Avg: {student2.CalcParticipationAvg()}\nQuiz Avg: {student2.CalcQuizAvg()}");

            Student student3 = new Student("Jones", "James", 113452684);
            student3.ExamGrades = new List<double>() { 100, 100};
            student3.FinalExamGrades = new List<double>() { 91, 90 };
            student3.HomeworkGrades = new List<double>() { 88, 97, 100, 92 };
            student3.ParticipationGrades = new List<double>() { 100, 95, 97, 98, 99 };
            student3.QuizGrades = new List<double>() { 97, 90, 92 };

            Console.WriteLine($"{student3.ToString()}");
            Console.WriteLine($"Exam Avg: {student3.CalcExamAvg()}\nFinal Exam Avg: {student3.CalcFinalExamAvg()}\nHomework Avg: {student3.CalcHWAvg()}\nParticipation Avg: {student3.CalcParticipationAvg()}\nQuiz Avg: {student3.CalcQuizAvg()}");

            Console.ReadKey();
        }
    }
}
