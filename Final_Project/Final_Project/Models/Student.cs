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
        public string GroupNo; 
        public string Type;
        private bool type;
        private byte _point;

        public byte CheckPoint
        {
            get
            {
                return _point;
            }
            set
            {
                if(value <= 70)
                {
                    Console.WriteLine($"You are guaranteed {_point}");
                    _point = value;
                }
                else
                {
                    Console.WriteLine($"You are not guaranteed {_point}");
                }
            }
        }
        Random rnd = new Random();

        public static int GenerateRandomInt(Random rnd)
        {
            return rnd.Next(100, 1000);
        }

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

        public Student(string fullname,string groupNo,string type)
        {
            Id = count++;
            Fullname = fullname;
            GroupNo = groupNo;
            Type = type;
        }

        public Student(string fullName, string groupNo, bool type)
        {
            Fullname = fullName;
            GroupNo = groupNo;
            this.type = type;
        }

        
    }
}
