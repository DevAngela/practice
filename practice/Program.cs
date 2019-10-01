using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "abc";
            var a = 11;
            var b = 5;
            var c = a * 1.0 / b;

            var kim = new Student
            {
                Name = "kim",
                Age = 10
            };
            var park = new Student { Name = "park", Age = 20 };
            var peter = new Student { Name = "peter", Age = 15 };

            var students = new List<Student> { kim, park, peter };

            var lee = new Student { Name = "lee", Age = 14 };
            students.Add(lee);

            // 학생들을 이름 순으로 정렬하고 그 중에서 위의 2명 학생의 이름을 가져온다
            var result0 = students
                .OrderBy(x => x.Name)
                .Take(2)
                .Select(x => x.Name)
                .ToList();

            var result01 = students
                .Select(x => x.Name)
                .OrderBy(x => x)
                .Take(2)
                .ToList();

            // 15살 이상인 학생들을 이름 순으로 정렬하고 그 중에서 위의 2명 학생의 이름을 가져온다
            var result2 = students
                .Where(x => x.Age >=15)
                .OrderBy(x => x.Name)
                .Take(2)
                .Select(x => x.Name)
                .ToList();

            // 학생들을 이름 순으로 정렬 하고, 학생의 이름, 나이만 골라서 익명 객체의 리스트로 반환
            var result3 = students
                .OrderBy(x => x.Name)
                .Select(x => new { Name = x.Name, Age = x.Age })
                .ToList();

            foreach (var na in result3)
            {
                Console.WriteLine($"{na.Name} {na.Age}");
            }

            var schoolA = new School
            {
                Name = "A",
                Students = students
            };

            var students2 = new List<Student>
            {
                new Student { Name = "s1", Age = 50 },
                new Student { Name = "s2", Age = 55 },
                new Student { Name = "s3", Age = 60 }
            };

            var schoolB = new School
            {
                Name = "B",
                Students = students2
            };

            var schools = new List<School>
            {
                schoolA,
                schoolB
            };

            // 전체 학교의 학생들을 나이 순으로 정렬을 하고, 이들의 학교명, 이름, 나이의 리스트로 반환
            var result4 = schools
                .SelectMany(x => x.Students
                    .Select(s => new { SchoolName = x.Name, Name = s.Name, Age = s.Age })
                )
                .OrderBy(x => x.Age)
                .ToList();


            // 제일 상위 학생을 가져온다
            var firstStudent = students
                .OrderBy(x => x.Name)
                .FirstOrDefault();

            var nums = new List<int> { 0, 1, 2 };
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(c);

            Console.WriteLine($"{text} abc");
            Console.WriteLine("Hello World!");
        }
    }
}
