using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Polymorphism_Application
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }

        public Employee(int id, string name, double baseSalary)
        {
            Id = id;
            Name = name;
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary * 12;
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Base Salary : {BaseSalary}");
        }
    }
}
