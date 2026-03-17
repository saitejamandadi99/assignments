using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public class Lab_Class : Course
    {
        public bool IsSafetyChecked { get; set; }
        public Lab_Class(string courseName, int capacity, bool isSafetyChecked) : base(courseName, capacity) {
            IsSafetyChecked = isSafetyChecked;
        }
        public override void EnrollStudent()
        {
            Console.WriteLine("Enrolling student in the Lab Class");
            if (StudentsEnrollment >= Capacity)
            {
                Console.WriteLine("Capacity Limit");
                return;
            }
            if (!IsSafetyChecked)
            {
                Console.WriteLine("Enrollment Failed : Safety Check Not compeleted");
                return;
            }
            StudentsEnrollment++;
            Console.WriteLine("Enrollment successful. ");
        }
    }
}
