using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    internal class Student
    {
        public static int count = 0;
        public int Id;
        public string Fullname;
        public int GroupNo;
        public string Type;


        public Student(string Fullname,int GroupNo,string Type)
        {
            Id = count++;
            this.Fullname = Fullname;
            this.GroupNo = GroupNo;
            this.Type = Type;
        }

    }
}
