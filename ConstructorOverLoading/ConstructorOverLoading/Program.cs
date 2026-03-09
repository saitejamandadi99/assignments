namespace ConstructorOverLoading
{

    public class Bmi
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }

        //constructor with different parameters providing flexibilty on initializing objects
        public Bmi()
        {
            Name = "Unknown";
            Weight = 0;
            Height = 0;
        }

        public Bmi(string name)
        {
            Name = name;
            Weight = 0;
            Height = 0;
        }

        public Bmi(string name, float weight, float height)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }
        public void DisplayBMIInfo()
        {
            float bmi = 0;
            if (Height > 0)
            {
                bmi = Weight / (Height * Height) ;
                bmi = bmi * 10000;
            }
            Console.WriteLine($"Name: {Name}, Weight: {Weight} kg, Height: {Height} cm,  BMI: {bmi}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmi s1 = new Bmi();
            Bmi s2 = new Bmi("jhon");
            Bmi s3 = new Bmi("Alice", 70.5f, 181.3f);
            s1.DisplayBMIInfo();
            s2.DisplayBMIInfo();
            s3.DisplayBMIInfo();
        }
    }
}