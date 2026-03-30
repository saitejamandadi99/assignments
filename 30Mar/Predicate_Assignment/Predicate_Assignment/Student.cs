using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Assignment
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public Student(string name, int age, int marks)
        {
            Name = name;
            Age = age;
            Marks = marks;
        }


    }
}
