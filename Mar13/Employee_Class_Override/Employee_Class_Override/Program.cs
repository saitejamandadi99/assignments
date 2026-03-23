namespace Employee_Class_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp1 = new Employee(1, "jacob", 35000);
            //FullTimeEmployee fEmp1 = new FullTimeEmployee(1, "Jacks", 30000, 20);
            //FullTimeEmployee fEmp2 = new FullTimeEmployee(1, "Jhon", 30000, 16);
            //PartTimeEmployee partime = new PartTimeEmployee(3, "jacb", 0, 20, 15);
            //Manager manager = new Manager(1, "Vinith", 30000, 20, 20000, "IT");
            //emp1.DisplayInfo();
            //fEmp1.DisplayInfo();
            //fEmp2.DisplayInfo();
            //partime.DisplayInfo();
            //manager.DisplayInfo();
            //manager.PrintHello();

            Employee[] employees = new Employee[4];
            employees[0] = new Employee(1, "jacob", 35000);
            employees[1] = new FullTimeEmployee(1, "Jacks", 30000, 20);
            employees[2] = new PartTimeEmployee(3, "jacb", 0, 20, 15);
            employees[3] = new Manager(1, "Vinith", 30000, 20, 20000, "IT");

            foreach(Employee e in employees)
            {
                e.DisplayInfo();
            }
        }
    }
}
