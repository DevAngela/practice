using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    public class Student
    {
        public string Name { get; set; }
        public int Room { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Student()
        {
            Name = "(이름)";
            Room = 1;
            Address = "(주소)";
            Age = 17;
        }

        public Student(int age)
        {
            Age = age;
        }

        public string SayName()
        {
            return $"My name is {Name}";
        }

    }
}
