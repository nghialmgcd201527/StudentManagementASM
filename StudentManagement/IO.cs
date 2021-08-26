using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class IO
    {
        public static void MenuBoard()
        {
            Console.WriteLine("\t\t|             LEEMINNGHIA'S APP             |");
            Console.WriteLine("\t\t|   [1] Add more student with their grade   |");
            Console.WriteLine("\t\t|   [2] Edit student grade by their ID      |");
            Console.WriteLine("\t\t|   [3] Remove student by their ID          |");
            Console.WriteLine("\t\t|   [4] Show all of student grade in class  |");
            Console.WriteLine("\t\t|   [5] Find the best student in class      |");
            Console.WriteLine("\t\t|   [6] Find the worst student in class     |");
            Console.WriteLine("\t\t|   [7] Find the student by ID              |");
            Console.WriteLine("\t\t|   [0] Exit the application                |");
            Console.Write("\n\t\t[Your choice] ");
        }

        public static bool ConfirmSubmissionBox()
        {
            Console.Write("\n\tSubmit [Y]");
            Console.WriteLine("\t\tUnsubmit [Any key]");
            Console.Write("\n\t>_");
            if (char.Parse(Console.ReadLine()) == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void HeaderOfListTable()
        {
             Console.WriteLine("\n\t| {0} | {1} | {2} | {3} | {4} | {5} |","ID", 
                                        "FULL NAME", "PHYSICAL GRADE", "MATH GRADE", "ENGLISH GRADE", "AVERAGE GRADE");
        }

        public static void ShowSuccessMessage()
        {
             Console.WriteLine("\n\tSubmit successfully !");
             Console.ReadKey();
        }

        public static void ShowFailMessage()
        {
            Console.WriteLine("\n\tYour change is not submited");
            Console.ReadKey();
        }

        public static void ShowRequestMessage()
        {
            Console.WriteLine("\n\tPress any key to return home screen");
        }
        
    }
}
