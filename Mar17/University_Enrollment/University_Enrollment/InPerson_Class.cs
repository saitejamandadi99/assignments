using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Enrollment
{
    public class InPerson_Class: Course
    {
        public int RoomNumber { get; set; }
        public InPerson_Class(string courseName, int capacity, int roomNumber) : base( courseName,  capacity)
        {
            RoomNumber = roomNumber;
        }
        public override void EnrollStudent()
        {
            Console.WriteLine("Enrolling the students in the In_person Class");
            if(StudentsEnrollment >= Capacity)
            {
                Console.WriteLine("Enrollment reached its limit");
                return;
            }
            if(RoomNumber == 0)
            {
                Console.WriteLine("Enrollment Failed : Room Number not provided");
                return;
            }
            StudentsEnrollment++;
            Console.WriteLine("Enrollement in In-person is successful");
        }
    }
}
