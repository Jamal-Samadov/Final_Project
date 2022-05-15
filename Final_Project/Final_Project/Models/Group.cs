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
        public static int GroupNo = 324;
        
        public static void GroupNumber(int count)
        {
            count++;
        }

        public int Limit { get; internal set; }

         

        public Group(string no,Categories category, bool isonline)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"P" + count;
                    break;
                case Categories.Graphic_Design:
                    No = $"GD" + count;
                    break;              
                case Categories.System_Administration:
                    No = $"SA" + count;
                    break;
            }
            count++;
            Category = category;

            IsOnline = isonline;
            if (IsOnline)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }

        }
        public override string ToString()
        {
            return $"{No} {Category}";
        }





    }

   
}
