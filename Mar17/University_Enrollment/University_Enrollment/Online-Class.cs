using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public class Online_Class : Course
    {
        public string VideoLink { get; set; }
        public Online_Class(string courseName, int capacity, string videoLink) : base(courseName, capacity) {
        VideoLink= videoLink;
        }
        public override void EnrollStudent()
        {
            Console.WriteLine("Enrolling students in the Online Class");
            if(StudentsEnrollment >= Capacity)
            {
                Console.WriteLine("Capacity limit . Enrollment Failed");
                return;
            }
            if (VideoLink == "")
            {
                Console.WriteLine("Enrollment failed : Video Link is not Provided");
                return;
            }
            StudentsEnrollment++;
            Console.WriteLine("Enrollment Success in Online class");
        }
    }
}
