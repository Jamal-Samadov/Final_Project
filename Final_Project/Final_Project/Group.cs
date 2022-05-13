using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    internal class Group
    {
        public string No;
        public string Category;
        public bool IsOnline;
        public int Limit;
        public string Students;



        public Group(string No,string Category,bool IsOnline,int Limit,string Students)
        {
            this.No = No;
            this.Category = Category;
            this.IsOnline = true;
            this.Limit = Limit;
            this.Students = Students;
        }
    }

   
}
