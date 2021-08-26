using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class UserChoice
    {
        Classroom classRoom = new Classroom();
        private static string InputIdStudent(int index)
        {
            Console.Write("\tENTER THE STUDENT ID [" + (index + 1) + "] \n\t>_");
            return (Console.ReadLine());
        }
        private static string InputStudentName(int index)
        {
            Console.Write("\n\tENTER THE STUDENT NAME [" + (index + 1) + "] \n\t>_");
            return (Console.ReadLine());
        }
        private static float InputStudentPhysicalGrade(int index)
        {
            Console.Write("\n\tENTER THE PHYSICAL GRADE [" + (index + 1) + "] \n\t>_");
            return (float.Parse(Console.ReadLine()));
        }
        private static float InputStudentMathGrade(int index)
        {
            Console.Write("\n\tENTER THE MATH GRADE [" + (index + 1) + "] \n\t>_");
            return (float.Parse(Console.ReadLine()));
        }
        private static float InputStudentEnglishGrade(int index)
        {
            Console.Write("\n\tENTER THE ENGLISH GRADE [" + (index + 1) + "] \n\t>_");
            return (float.Parse(Console.ReadLine()));
        }
        private static Student CreateNewStudentInfor(int index)
        {
            Student student = new Student(InputIdStudent(index), InputStudentName(index), InputStudentPhysicalGrade(index),
                                                    InputStudentMathGrade(index), InputStudentEnglishGrade(index));
            return student;
        }
        public void ShowStudentWithLowestMark()
        {
            IO.HeaderOfListTable();
            classRoom.PrintStudentWithLowestGrade();
            Console.ReadKey();
        }
        public void ShowStudentWithHighestMark()
        {
            IO.HeaderOfListTable();
            classRoom.PrintStudentWithHighestGrade();
            Console.ReadKey();
        }
        public void InputListStudent()
        {
            int amount;
            bool isValid;
            Console.Write("\n\t\tEnter amount of student :>_");
            try
            {
                amount = classRoom.Students.Count + int.Parse(Console.ReadLine());
                for (int i = classRoom.Students.Count; i < amount; i++)
                {
                    Student student = new Student();
                    do
                    {
                        student = CreateNewStudentInfor(i);
                        isValid = IsValidationData(student);
                    } while (isValid == false);
                    if (IO.ConfirmSubmissionBox())
                    {
                        classRoom.Students.Add(student);
                        IO.ShowSuccessMessage();
                    }
                    else
                    {
                        student = null;
                        IO.ShowFailMessage();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\tSomething wrong happen!" +
                                  "\n\n\tDetail: " + e.Message);
                Console.ReadKey();
            }
        }
        public void InputEditStudentInfor()
        {
            string idStudent;
            float gradeMath;
            float gradePhysical ;
            float gradeEnglish;
            Student student = new Student();
            Console.Write("\n\tENTER THE STUDENT ID\n\t>_");
            idStudent = Console.ReadLine();
            do
            {
                Console.WriteLine("\n\tENDING STUDENT [" + idStudent + "]");
                Console.Write("\n\tNEW PHYSICAL GRADE \n\t>_");
                float.TryParse(Console.ReadLine(), out gradePhysical);
                Console.Write("\n\tNEW MATH GRADE \n\t>_");
                float.TryParse(Console.ReadLine(), out gradeMath);
                Console.Write("\n\tNEW ENGLISH GRADE \n\t>_");
                float.TryParse(Console.ReadLine(), out gradeEnglish);
                student.EditGrade(gradePhysical, gradeMath, gradeEnglish);
            } while (!IsValidationData(student));
            classRoom.EditGradeByID(idStudent, gradePhysical, gradeMath, gradeEnglish);
            Console.ReadKey();
        }
        public void InputRemovingStudentID()
        {
            string id;
            Console.Write("\n\tENTER STUDENT ID\n\t>_");
            id = Console.ReadLine();
            classRoom.RemoveStudentByID(id);
            Console.ReadKey();
        }
        public void FindStudentByID()
        {
            string idStudent;
            Console.WriteLine("\tENTER THE FINDING STUDENT ID");
            Console.Write("\t>_");
            idStudent = Console.ReadLine();
            classRoom.GetStudentByID(idStudent);
            Console.ReadKey();
        }
        public void DisplayAllStudents()
        {
            classRoom.PrintAllStudents();
            Console.WriteLine("\n\tPress any key to return home screen");
            Console.ReadKey();
        }
        private static bool IsValidationData(Student student)
        {
            return ((student.EnglishGrade >= 0 && student.EnglishGrade <= 10) &&
                    (student.MathGrade >= 0 && student.MathGrade <= 10) &&
                    (student.PhysicalGrade >= 0 && student.PhysicalGrade <= 10));
        }
    }
}
