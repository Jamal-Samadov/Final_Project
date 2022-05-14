using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Interfaces
{
    internal interface IGroupServiceAble
    {
        public List<Group> Groups { get; }
        string CreateGroup();
        void ShowAllGroup();
        void EditGroup(string oldNo, string newNo);
        void ShowAllStudentsByGroup();
        void ShowAllStudents();
        void CreateStudents();
        void RemoveStudents();
    }
}
