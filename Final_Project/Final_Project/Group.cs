using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
     class Group
    {
        public static string No;
        public bool IsOnline;

        byte _limit;
        public string Students;
        public Categories Category;
        public static int count = 324;






        public Group(string no,Categories category)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"P" + count;
                    break;
                case Categories.GraphicDesign:
                    No = $"GD" + count;
                    break;              
                case Categories.SystemAdministration:
                    No = $"SA" + count;
                    break;
            }
            count++;
            Category = category;
            

        }

        //public Group(string no,Categories category,int limit,string students)
        //{
        //    No = no;
        //    Category = category;
        //    Limit = limit;
        //    Students = students;
        //    IsOnline = false;
        //}



       
    }

   
}
