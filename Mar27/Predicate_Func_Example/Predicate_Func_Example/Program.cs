namespace Predicate_Func_Example
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            Console.WriteLine($"result: {add(10,20)}");
        }
    }
}
