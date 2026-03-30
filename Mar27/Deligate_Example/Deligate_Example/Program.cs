namespace Deligate_Example
{
    internal class Program
    {
        public delegate void delCalculate(int a, int b);
        public delegate void Calculations(int a, int b);
        static void Main(string[] args)
        {
            delCalculate newSum = new delCalculate(CalcuSum);
            newSum(50, 10);
            newSum.Invoke(10, 10);
            Console.WriteLine("---_After MultiCasting----");
            newSum += Calc;
            newSum(10, 5);
            Console.WriteLine("-----Remove MultiCasting");
            newSum -= Calc;
            newSum.Invoke(10, 5);

            Console.WriteLine("---Anonymus delegate function----");
            Calculations calculate = delegate (int a, int b)
            {
                Console.WriteLine($"Calculate: {a + b}");
            };

            calculate(100, 500);

        }

        public static void CalcuSum(int a, int b)
        {
            Console.WriteLine($"Total sum: {a+b}");
        }

        public static void Calc(int a , int b)
        {
            Console.WriteLine($"Multiplication {a*b}");
        }
    }
}
