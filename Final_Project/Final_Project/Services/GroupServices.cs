using Final_Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Services
{
    class GroupServices : IGroupServiceAble
    {
        List<Group> _groups;
        public List<Group> Groups => _groups;

        public string CreateGroup()
        {
            throw new NotImplementedException();
        }

        public void CreateStudents()
        {
            throw new NotImplementedException();
        }

        public void EditGroup(string oldNo, string newNo)
        {
            Group group = null;
            foreach (Group existed in Groups)
            {
                if (existed.No.ToLower == oldNo)
                {
                    group = existed; 
                    break;
                }
            }
        }

        public void RemoveStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowAllGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudentsByGroup()
        {
            throw new NotImplementedException();
        }
    }
}
