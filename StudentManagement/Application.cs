using System;

namespace StudentManagement
{
    class Application
    {
        public void Run()
        {
            int choice;
            bool isValidChoice;
            UserChoice userChoice = new UserChoice();
            do
            {
                IO.MenuBoard();
                isValidChoice = int.TryParse(Console.ReadLine(), out choice);
                if (isValidChoice)
                {
                    switch (choice)
                    {
                        case 1:
                            userChoice.InputListStudent();
                            break;
                        case 2:
                            userChoice.InputEditStudentInfor();
                            break;
                        case 3:
                            userChoice.InputRemovingStudentID();
                            break;
                        case 4:
                            userChoice.DisplayAllStudents();
                            break;
                        case 5:
                            userChoice.ShowStudentWithHighestMark();
                            break;
                        case 6:
                            userChoice.ShowStudentWithLowestMark();
                            break;
                        case 7:
                            userChoice.FindStudentByID();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n\tYou have chosen invalid selection ! Peease try again!");
                    Console.ReadKey();
                }
            } while (choice > 0 || isValidChoice == false);
            userChoice = null;
            Console.WriteLine("\n\tSEE YOU SOON !");
        }
    }
}
