using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Polymorphism_Application
{
    public class Tester : Employee
    {
        public Tester(int id, string name, double baseSalary) : base(id, name, baseSalary)
        {

        }

        public override double CalculateSalary()
        {
            double perks = 0.3 * BaseSalary;
            double monthlySalary = BaseSalary + perks;
            return monthlySalary * 12;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Tester");
            Console.WriteLine($"Annual CTC: {CalculateSalary()}");
        }
    }
}
