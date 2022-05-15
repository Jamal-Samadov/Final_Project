using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Interfaces
{
    internal interface IGroupServiceAble
    {
        public List<Group> Groups { get; }
        void CreateGroup(byte category, byte offandon);
        void ShowAllGroup();
        void EditGroup(string oldNo, string newNo);
        void ShowAllStudentsByGroup(string no);
        void ShowAllStudents();
        void CreateStudents(string name, string surname);
        void RemoveStudents();
    }
}
