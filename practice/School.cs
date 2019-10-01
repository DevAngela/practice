using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice
{
    public class School
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public int NumOfStudents()
        {
            return Students.Count;
        }

        public Student OldestStudent()
        {
            var result = Students
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();
            return result;
        }
    }
}
