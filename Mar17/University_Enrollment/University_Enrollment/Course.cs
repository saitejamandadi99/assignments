using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public abstract class Course
    {
        public string CourseName { get; set; }
        public int Capacity { get; set; }
        public int StudentsEnrollment { get; set; }

        public Course(string courseName, int capacity)
        {
            CourseName = courseName;
            Capacity = capacity;
            StudentsEnrollment = 0;
        }
        public abstract void EnrollStudent();

        public virtual void Display()
        {
            Console.WriteLine($"Course : {CourseName}, Capacity:{Capacity}, Enrolled Students: {StudentsEnrollment}");
        }

    }
}
