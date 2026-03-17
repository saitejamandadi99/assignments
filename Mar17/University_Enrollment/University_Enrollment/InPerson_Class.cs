using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public class InPerson_Class: Course
    {
        public InPerson_Class(string courseName, int capacity) : base( courseName,  capacity)
        {
        }
        public override void EnrollStudent()
        {
            Console.WriteLine("Enrolling the students in the In_person Class");
            if(StudentsEnrollment >= Capacity)
            {
                Console.WriteLine("Enrollment reached its limit");
                return;
            }
            StudentsEnrollment++;
            Console.WriteLine("Enrollement in In-person is successful");
        }
    }
}
