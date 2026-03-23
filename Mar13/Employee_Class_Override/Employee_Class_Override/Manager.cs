using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Employee_Class_Override
{
    public class Manager: FullTimeEmployee
    {
        public double Bonus { get; set; }
        public string Department { get; set; }
        public Manager(int id, string name, double salary , int leaves, double bonus, string department) : base(id, name, salary, leaves)
        {
            Bonus = bonus;
            Department = department;
        }
        public override double CalculateSalary()
        {
            return Salary + Bonus;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Details\n Id: {Id}, Name: {EmpName}, Leaves : {LeavesTaken}, Bonus : {Bonus}, Salary: {CalculateSalary()} Department : {Department}");
        }
    }
}
