using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    internal class Student
    {
        public static int count = 100;
        private static int _Id;      
        public string Fullname;
        public static int GroupNo = 300; 
        public string Type;


        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public Student(string fullname,int groupNo,string type)
        {
            Id = count++;
            Fullname = fullname;
            GroupNo = groupNo;
            Type = type;
        }

    }
}
