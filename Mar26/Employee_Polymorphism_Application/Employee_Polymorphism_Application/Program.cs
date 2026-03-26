namespace Employee_Polymorphism_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListEmployee = new List<Employee>();
            ListEmployee.Add(new Manager(1, "Sai", 30000));
            ListEmployee.Add(new Developer(2, "Jhon", 30000));
            ListEmployee.Add(new Tester(3, "Jacob", 30000));

            foreach(Employee e in ListEmployee)
            {
                e.Display();
                Console.WriteLine();
            }
        }
    }
}
