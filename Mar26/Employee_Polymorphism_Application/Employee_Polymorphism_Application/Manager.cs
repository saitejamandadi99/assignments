using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Polymorphism_Application
{
    public class Manager : Employee
    {
        public Manager(int id, string name, double baseSalary) : base(id, name, baseSalary)
        {

        }

        public override double CalculateSalary()
        {
            double ta = 0.5 * BaseSalary;
            double da = 0.4 * BaseSalary;
            double monthlySalary = BaseSalary + ta + da;
            return monthlySalary * 12;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Manager");
            Console.WriteLine($"Annual CTC: {CalculateSalary()}");
        }
    }
}
