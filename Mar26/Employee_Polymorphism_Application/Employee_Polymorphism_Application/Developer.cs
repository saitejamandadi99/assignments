using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Polymorphism_Application
{
    public class Developer : Employee
    {
        public Developer(int id, string name, double baseSalary) : base(id, name, baseSalary)
        {

        }

        public override double CalculateSalary()
        {
            double pa = 0.4 * BaseSalary;
            double monthlySalary = BaseSalary + pa;
            return monthlySalary * 12;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Developer");
            Console.WriteLine($"Annual CTC: {CalculateSalary()}");
        }
    }
}
