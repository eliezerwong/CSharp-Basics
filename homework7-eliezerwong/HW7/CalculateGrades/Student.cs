using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateGrades
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public int StudentID;
        public List<double> ExamGrades;
        public List<double> FinalExamGrades;
        public List<double> HomeworkGrades;
        public List<double> ParticipationGrades;
        public List<double> QuizGrades;

        public Student()
        {

        }

        public Student(int studentID)
        {
            StudentID = studentID;
        }

        public Student(string firstName, string lastName, int studentID)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = studentID;
        }

        public string ToString()
        {
            return $"{FirstName}, {LastName} ({StudentID})";
        }

        public double CalcExamAvg()
        {
            double avg = 0;
            double sum = 0;
            foreach (var grade in ExamGrades)
            {
                sum += grade;
            }
            avg = sum / 2;
            return avg;
        }

        public double CalcFinalExamAvg()
        {
            double avg = 0;
            double sum = 0;
            foreach (var grade in FinalExamGrades)
            {
                sum += grade;
            }
            avg = sum / 2;
            return avg;
        }

        public double CalcHWAvg()
        {
            double avg = 0;
            double sum = 0;
            foreach (var grade in HomeworkGrades)
            {
                sum += grade;
            }
            avg = sum / 4;
            return avg;
        }

        public double CalcParticipationAvg()
        {
            double avg = 0;
            double sum = 0;
            foreach (var grade in ParticipationGrades)
            {
                sum += grade;
            }
            avg = sum / 5;
            return avg;
        }

        public double CalcQuizAvg()
        {
            double avg = 0;
            double sum = 0;
            foreach (var grade in QuizGrades)
            {
                sum += grade;
            }
            avg = sum / 3;
            return avg;
        }

    }
}
