using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public class Online_Class : Course
    {
        public Online_Class(string courseName, int capacity) : base(courseName, capacity) { }
        public override void EnrollStudent()
        {
            Console.WriteLine("Enrolling students in the Online Class");
            if(StudentsEnrollment >= Capacity)
            {
                Console.WriteLine("Capacity limit . Enrollment Failed");
                return;
            }
            StudentsEnrollment++;
            Console.WriteLine("Enrollment Success in Online class");
        }
    }
}
