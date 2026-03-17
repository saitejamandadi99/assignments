using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public class Lab_Class : Course
    {
        public Lab_Class(string courseName, int capacity) : base(courseName, capacity) { }
        public override void EnrollStudent()
        {
            Console.WriteLine("Enrolling student in the Lab Class");
            if (StudentsEnrollment >= Capacity)
            {
                Console.WriteLine("Capacity Limit");
                return;
            }
            StudentsEnrollment++;
            Console.WriteLine("Enrollment successful. ");
        }
    }
}
