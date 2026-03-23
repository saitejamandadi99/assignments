using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Override
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        
        public Employee(int id, string name, double salary)
        {
            Id = id;
            EmpName = name;
            Salary = salary;
        }
        public virtual double CalculateSalary()
        {
            return Salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee details\n Id: {Id}, Name: {EmpName}, Salary: {CalculateSalary()}");
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello Employee");
        }
    }
}
