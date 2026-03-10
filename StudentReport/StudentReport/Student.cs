using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReport
{
    public class Student
    {
        public string StudentName { get; set; }
        public int RollNumber { get; set; }
        public int[] MarksArray { get; set; }

        public int AverageMarks { get; set; }

        public string Grade { get; set; }



        public Student(string name, int rollnumber , int[] marks)
        {
            StudentName = name;
            RollNumber = rollnumber;
            MarksArray = marks;

            CalculateAverage();
            CalculateGrade();
        }

        public override string ToString()
        {
            return $"Student: {StudentName}, Roll Number: {RollNumber}, Marks: {string.Join(", ",MarksArray)}, Average: {AverageMarks}, Grade: {Grade} ";
        }

        public void CalculateAverage()
        {
            int total = 0;
            foreach (int mark in MarksArray)
            {
                total += mark;
            }
            AverageMarks =  total / MarksArray.Length;
        }

        public void CalculateGrade()
        {
            if (AverageMarks >= 90)
            {
                Grade = "A+";
            }
            else if (AverageMarks >= 80)
            {
                Grade = "A";
            }
            else if (AverageMarks >= 70)
            {
                Grade = "B";
            }
            else if (AverageMarks >= 60)
            {
                Grade = "C";
            }

            else if (AverageMarks >= 50)
            {
                Grade = "D";
            }
            else
            {
                Grade = "F";
            }
        }

    }
}
