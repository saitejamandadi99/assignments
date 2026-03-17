namespace University_Enrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Online_Class(".net", 200);
            Course c2 = new InPerson_Class("Full stack", 1);
            Course c3 = new Lab_Class("Computers", 20);
            Console.WriteLine("\n------Printing Online Class Details-----\n");
            c1.EnrollStudent();
            c1.Display();
            Console.WriteLine("\n------Printing In Person Class Details-----\n");

            c2.EnrollStudent();
            c2.EnrollStudent();
            c2.EnrollStudent();
            c2.Display();
            Console.WriteLine("\n------Printing Lab Class Details-----\n");

            c3.EnrollStudent();
            c3.EnrollStudent();
            c3.Display();
        }
    }
}
