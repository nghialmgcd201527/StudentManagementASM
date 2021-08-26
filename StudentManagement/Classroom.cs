using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Classroom
    {
        public List<Student> Students = new List<Student>();
        public void RemoveStudentByID(string id)
        {
            Student studentInBatch = Students.FirstOrDefault(std => std.Id.Equals(id));
            bool confirm = IO.ConfirmSubmissionBox();
            if(confirm && studentInBatch != null)
            {
                Console.WriteLine("\n\tYOUR REQUEST IS SUBMITED !");
                Students.Remove(studentInBatch);
            }
            else if (!confirm)
            {
                Console.WriteLine("\n\tYOUR REQUEST IS NOT SUBMITED !");
            }
            else
            {
                Console.WriteLine("\n\tYou cannot remove a student who does not exist!");
            }
        }
        public void PrintAllStudents()
        {
            IO.HeaderOfListTable();
            foreach (Student student in Students)
            {
                student.PrintInformation();
            }
        }
        public void GetStudentByID(string id)
        {
            Student studentInBatch = Students.FirstOrDefault(std => std.Id.Equals(id));
            if (studentInBatch != null)
            {
                IO.HeaderOfListTable();
                studentInBatch.PrintInformation();
                IO.ShowRequestMessage();
            }
            else
            {
                Console.WriteLine("\n\tTHIS STUDENT DOESN'T EXIST !");
            }
        }
        public void EditGradeByID(string id, float physicalGrade, float mathGrade, float englishGrade)
        {
            Student studentInBatch = Students.FirstOrDefault(std => std.Id.Equals(id));
            if (studentInBatch != null)
            {
                if (IO.ConfirmSubmissionBox())
                {
                    studentInBatch.EditGrade(physicalGrade, mathGrade, englishGrade);
                    Console.WriteLine("\n\tTHIS REVISION HAS BEEN SUBMITED !");
                }
                else
                {
                    Console.WriteLine("\n\tTHIS REVISION HAS BEEN DELETED !");
                    return;
                }
            }
            else
            {
                Console.WriteLine("\n\tTHIS STUDENT DOESN'T EXIST !");
            }
        }
        public void PrintStudentWithHighestGrade()
        {
            var result = Students.OrderByDescending(student => student.CalculateAverage()).ToList();
            foreach (Student student in Students)
            {
                if (student.CalculateAverage() == result[0].CalculateAverage())
                {
                    student.PrintInformation();
                }
            }
            IO.ShowRequestMessage();
        }
        public void PrintStudentWithLowestGrade()
        {
            var result = Students.OrderBy(student => student.CalculateAverage()).ToList();
            foreach (Student student in Students)
            {
                if (student.CalculateAverage() == result[0].CalculateAverage())
                {
                    student.PrintInformation();
                }
            }
            IO.ShowRequestMessage();
        }
    }
}
