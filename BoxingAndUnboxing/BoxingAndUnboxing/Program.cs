namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10; //value type 
            object obj = number; //boxing the value type into an reference type
            Console.WriteLine($"boxed value: {obj}, {obj.GetType()}, {typeof(object)}"); // 

            int newNumber = (int)obj; //unboxing the reference type back to value type
            Console.WriteLine($"unboxed values: {newNumber}, {newNumber.GetType()}, {typeof(int)}");
        
        }
    }
}
