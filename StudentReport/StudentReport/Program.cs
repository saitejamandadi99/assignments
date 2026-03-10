namespace StudentReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("ajith", 1, [60, 70, 98, 78, 66]);
            Student student2 = new Student("Vicky", 2, [50, 90, 88, 98, 77]);
            Student student3 = new Student("Arjun", 3, [99, 88, 100, 100, 99]);
            Student student4 = new Student("Vijay", 4, [50, 70, 98, 38, 26]);
            Console.WriteLine("Printing Student Details\n");
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());
            Console.WriteLine(student4.ToString());
        }
    }
}
