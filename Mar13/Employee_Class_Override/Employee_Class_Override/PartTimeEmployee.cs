using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Override
{
    public class PartTimeEmployee : Employee
    {
        public int NoOfHours { get; set; }
        public int RatePerHour { get; set; }
        public PartTimeEmployee(int id, string name, double salary, int noOfHours, int ratePerHour) : base(id, name, salary)
        {
            NoOfHours = noOfHours;
            RatePerHour = ratePerHour;

        }

        public override double CalculateSalary()
        {
            return NoOfHours * RatePerHour;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Part Time Employee Details\n Id: {Id}, Name: {EmpName}, Salary: {CalculateSalary()}");
        }
    }
}
