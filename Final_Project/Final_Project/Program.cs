using Final_Project.Services;
using System;

namespace Final_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello guys. Welcoxme to our Academy. You are right adress!");
            Console.WriteLine("\nOkey let's introduce our course \nWhich course do you want to choose?\n");

            int selection;
            do
            {
                Console.WriteLine("1. Create Group");
                Console.WriteLine("2. Show All Group");
                Console.WriteLine("3. Edit Group");
                Console.WriteLine("4. Show All Students By Group");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Create Student");
                Console.WriteLine("7. Remove Students");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                if (result)
                {
                    switch (selection)
                    {
                      case 1:
                            MenuServices.CreatehallMenu();                      
                            break;
                            case 2:
                            MenuServices.ShowAllGroupMenu();
                            break;
                        case 3:
                            MenuServices.EditGroupMenu();
                            break;
                        case 4:
                            MenuServices.ShowAllStudentsByGroupMenu();
                            break;
                        case 5:
                            MenuServices.ShowStudentsMenu();
                            break;
                        case 6:
                            MenuServices.CreateStudentMenu();
                            break;
                        case 7:
                            MenuServices.RemoveStudentsMenu();
                            break;
                        default:
                            Console.WriteLine("Something went wrong");
                            break;

                    }


                }

            } while (selection != 0);


        }            

        
    }
}
