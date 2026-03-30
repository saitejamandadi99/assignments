namespace Predicate_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter the Name of student");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Marks of Student");
                int.TryParse(Console.ReadLine(), out int marks);
                Console.WriteLine("Enter the Age of Student");
                int.TryParse(Console.ReadLine(), out int age);

                studentList.Add(new Student(name, age, marks));
                Console.WriteLine("Student Added\n");
            }

            Predicate<Student> MarksAbove = s => s.Marks > 60;
            var result1 = studentList.FindAll(MarksAbove);
            Console.WriteLine("\n---Printing student above 60 marks---\n");
            foreach(var r in result1)
            {
                Console.WriteLine($"{r.Name}-{r.Marks}");
            }


            Predicate<Student> AgeAbove = s => s.Age < 18;
            var result2 = studentList.FindAll(AgeAbove);
            Console.WriteLine("\n---Printing student Less than 18 years---\n");
            foreach (var r in result2)
            {
                Console.WriteLine($"{r.Name}-{r.Age}");
            }

            Predicate<Student> startsWithA = s => s.Name.StartsWith("A");
            var result3 = studentList.FindAll(startsWithA);
            Console.WriteLine("\n---Printing student Starts with A ---\n");
            foreach (var r in result2)
            {
                Console.WriteLine($"{r.Name}");
            }

            //using exists () 

            bool hasTopper = studentList.Exists(s => s.Marks > 90);
            Console.WriteLine("Is there any student with marks > 90? " + hasTopper);

            bool hasAge = studentList.Exists(s => s.Age < 18);
            Console.WriteLine("Is there any student age < 18? " + hasAge);

        }
    }
}
