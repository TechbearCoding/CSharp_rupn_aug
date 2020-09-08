using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Objects
{
    class Student
    {
        public String Name { get; set; }
        public String LastName { get; set; }

        private int _course;

        public int Course 
        {
            get 
            {
                return _course;
            }
            set 
            {
                if(value >= 1 && value <= 3)
                {
                    _course = value;
                }
                else if(value > 3)
                {
                    _course = 3;
                }
                else
                {
                    _course = 1;
                }
            }

        }

        public Student(String name, String lastName, int course)
        {
            Name = name;
            LastName = lastName;
            Course = course;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + LastName + " " + Course);
        }
    }
}
