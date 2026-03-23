using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Employee_Class_Override
{
    public class FullTimeEmployee : Employee
    {
        private int _leavesTaken;
        public int LeavesTaken { get { return _leavesTaken; } set
            {
                if (value < 20)
                {
                    _leavesTaken = value;
                }
                else
                {
                    _leavesTaken = 20;
                }
            } 
        }

        public FullTimeEmployee(int id, string name, double salary, int leaves) : base(id, name, salary)
        {
            LeavesTaken = leaves;
        }
        public override double CalculateSalary()
        {
            return Salary;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Full Time Employee Details\n Id: {Id}, Name: {EmpName}, Salary: {CalculateSalary()}, LeavesTaken: {LeavesTaken}");
        }
    }
}
