using Final_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Services
{
    class GroupServices : IGroupServiceAble
    {
        List<Group> _groups = new List<Group>();
        List<Student> _students = new List<Student>();

        public List<Group> Groups => _groups;
        public List<Student> students => _students;

        public void CreateGroup(byte category, byte offandon)
        {
            if(category <= 0 || offandon <= 0 )
            {
                Console.WriteLine("Please choose any category");
            }
               
        }
        public void CreateStudents(string name, string surname)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("Please again write");
                return;
            }
            if(name.ToUpper().Trim() == surname.ToUpper().Trim() || name.ToLower().Trim() == surname.ToLower().Trim())
            {
                Console.WriteLine("Please again write");
                return;
            }
            
           
        }

        public void EditGroup(string oldNo, string newNo)
        {
            if(FindGroup(newNo) == null)
            {
                Group group = FindGroup(oldNo);
                if(group != null)
                {
                    Group.No = newNo.ToUpper().Trim();
                    Console.WriteLine($"{newNo} => Succesfully created");
                }
                else
                {
                    Console.WriteLine($"There is groupNo --- {oldNo}");
                }               
            }
            else
            {

                Console.WriteLine($"There is group --- {newNo}");
            }  


        }
        
        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (Group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }

        public void RemoveStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowAllGroup()
        {
                foreach(Group group in Groups)
                {
                    Console.WriteLine(group.ToString());
                }

        }

        public void ShowAllStudents()
        {
            if (Student.count > 0)
            {
                foreach(Student stu in _students)
                {
                    Console.WriteLine(stu);
                }
            }
            else
            {
                Console.WriteLine("Here is no students yet");
            }
            

        }

        public void ShowAllStudentsByGroup(string no)
        {
            Group group = FindGroup(no);
            if(group != null)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Please enter valig group no"); 
            }
        }

        
    }
}
