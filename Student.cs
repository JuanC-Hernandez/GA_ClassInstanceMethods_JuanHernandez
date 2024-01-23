using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ClassInstanceMethods_JuanHernandez
{
    internal class Student
    {
        public string Name { get; set; }
        public List<int> ExamScores { get; private set; }

        public Student(string name) // Constructor to contain name
        {
            Name = name;
            ExamScores = new List<int>();
        }

        public Student(string name, List<int> examScores) // Constructor to contain name and list
        {
            Name = name;
            ExamScores = examScores;
        }
        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                ExamScores.Add(grade);
                Console.WriteLine($"Added grade {grade} for {Name}");
            }
            else
            {
                Console.WriteLine($"Invalid grade: {grade}. Grade must be between 0 and 100."); // Displays error message
            }

        }
        public double CalculateAverageScore()
        {
            if (ExamScores.Count == 0)
            {
                return 0;
            }

            int totalScore = 0;
            foreach (int score in ExamScores)
            {
                totalScore += score;
            }

            return (double)totalScore / ExamScores.Count;
        }

        public char GetGrade() // gets letter grade
        {
            double averageScore = CalculateAverageScore();

            if (averageScore >= 90)
            {
                return 'A';
            }
            else if (averageScore >= 80)
            {
                return 'B';
            }
            else if (averageScore >= 70)
            {
                return 'C';
            }
            else if (averageScore >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        public void DisplayStudentInfo() //displays information
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Average Score: {CalculateAverageScore():F2}");
            Console.WriteLine($"Grade: {GetGrade()}");
        }
        public void DisplayAllGrades() //displays grade and letter
        {
            Console.WriteLine($"Grades for {Name}:");
            for (int i = 0; i < ExamScores.Count; i++)
            {
                char letterGrade = GetLetterGrade(ExamScores[i]);
                Console.WriteLine($"Exam {i + 1}: {letterGrade} ({ExamScores[i]})");
            }
        }
        private char GetLetterGrade(int score) //gets letter grade
        {
            if (score >= 90)
            {
                return 'A';
            }
            else if (score >= 80)
            {
                return 'B';
            }
            else if (score >= 70)
            {
                return 'C';
            }
            else if (score >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}
