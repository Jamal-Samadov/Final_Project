using Final_Project.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Services
{
    static class MenuServices
    {
        public static GroupServices groupServices = new GroupServices();

        public static void CreateGroupMenu()
        {
            cc:
            Console.WriteLine("\nPlease choose any category");
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}.  {item}");
            }
            object categoriy;
            bool categoriesResult = Enum.TryParse(typeof(Categories), Console.ReadLine(), out categoriy);
            if (categoriesResult)
            {

                Console.WriteLine(categoriy);
            }
            else
            {
                Console.WriteLine("Something went wrong");
                goto cc;
            }
        aa:
            Console.WriteLine("1. Online \n2. Offline \nPlease choose option Offline or Online lesson\n");
            byte offandon;
            bool OffandOnResult = byte.TryParse(Console.ReadLine(), out offandon);

            if (offandon <= 3)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Congratulations, a new group was created");
                Console.WriteLine("*************");
                Console.WriteLine("Your Group: " + categoriy + "\nYour Type is: " + offandon + "\n" + "Your Group No:" + Group.GroupNo);
                Console.WriteLine("*************");
            }
            else
            {
                Console.WriteLine("Wrong choose. Please choose again");
                goto aa;
            }

            if (categoriesResult)
            {

                groupServices.CreateGroup((byte)(Categories)categoriy, offandon);
            }
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Please enter old group no ");
            string no = Console.ReadLine();

            Console.WriteLine("Please enter new group no");
            string newNo = Console.ReadLine();
            groupServices.EditGroup(newNo, no);

        }

        public static void ShowAllStudentsByGroupMenu()
        {
            Console.WriteLine("Please enter group no ");
            string no = Console.ReadLine();
            groupServices.ShowAllStudentsByGroup(no);

        }
        public static void RemoveStudentsMenu()
        {
            string student = "1. Fullname: Elshan Aliyev, Group: P-324, Type: Zemanetli";
            string student1 = "2. Fullname: Khalilbey Khalilbeyli Group: GD-325 Type: Zemanetsiz";
            string student2 = "3. Fullname: Kamran Gasimov Group: SA-326, Type: Zemanetli";
            Console.WriteLine("\nAll students\n" + student + " \n" + student1 + "\n" + student2 + "\n");
            string choose = Console.ReadLine();
            Console.WriteLine("Your choosing: " + choose);
            Console.WriteLine("\nWhy do you want to remove the student? Please explain the reason\n");

            foreach (var item in Enum.GetValues(typeof(Reason)))
            {
                Console.WriteLine($"{(int)item}.  {item}");
            }
            object reasons;
            bool reasonsResult = Enum.TryParse(typeof(Reason), Console.ReadLine(), out reasons);
            if (reasonsResult)
            {

                Console.WriteLine(reasons);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            Console.WriteLine("\nThe student was deleted. Good luck\n");

            System.Threading.Thread.Sleep(3000);
            Console.Clear();


        }
        public static void ShowAllGroupMenu()
        {
            foreach (var item in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}.  {item}");
            }
            object categ;
            Console.WriteLine("\n");
        }
        public static void CreateStudentMenu()
        {
            Console.WriteLine("Please write your name:");
            string name = Console.ReadLine();         
            Console.WriteLine("\nPlease write your surname:");            
            string surname = Console.ReadLine();
            System.Threading.Thread.Sleep(1000);

            int number;
            Console.WriteLine("\nPlease waiting, Your information is confirmed\n");
            System.Threading.Thread.Sleep(2000);
            Random num = new Random();
            number = num.Next();

            Console.WriteLine("***********");
            Console.WriteLine("Fullname: " + name + " " + surname + "\n" + "Your ID number: " + num.Next(1000));
            string result = name + surname + num.Next(1000);
            Console.WriteLine("***********");
        }
        public static void ShowAllStudentsMenu()
        {
            string student = "Fullname: Elshan Aliyev, Group: P-324, Type: Zemanetli";
            string student1 = "Fullname: Khalilbey Khalilbeyli, Group: GD-325, Type: Zemanetsiz";
            string student2 = "Fullname: Kamran Gasimov, Group: SA-326, Type: Zemanetli";
            Console.WriteLine("\nAll students\n" + "\n" + student + " \n" + student1 + "\n" + student2 + "\n");
            
        }


}   }
