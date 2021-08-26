using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Student
    {
        public string Id;
        public string NameOfStudent;
        public float PhysicalGrade;
        public float MathGrade;
        public float EnglishGrade;

        public Student()
        {

        }

        public Student(string id, string nameOfStudent, float physicalGrade,
                        float mathGrade, float englishGrade)
        {
            Id = id;
            NameOfStudent = nameOfStudent;
            PhysicalGrade = physicalGrade;
            MathGrade = mathGrade;
            EnglishGrade = englishGrade;
        }

        public void EditGrade(float physicalGrade, float mathGrade, float englishGrade)
        {
            PhysicalGrade = physicalGrade;
            MathGrade = mathGrade;
            EnglishGrade = englishGrade;
        }

        public void PrintInformation()
        {
            Console.WriteLine("\t| {0} | {1} | {2} | {3} | {4} | {5} |", 
                              Id, NameOfStudent, PhysicalGrade, MathGrade, EnglishGrade, CalculateAverage());
        }

        public double CalculateAverage()
        {
            double result = (Math.Round(((PhysicalGrade + MathGrade + EnglishGrade) / 3), 1));
            return result;
        }

    }
}
