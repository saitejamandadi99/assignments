using System.Data;
using System.Linq.Expressions;

namespace Params
{

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int count;
            Methods method = new Methods();
            method.Addition(out count, 1, 2, 3, 4, 5, 6);
            Console.WriteLine($"Count of the params is : {count}");
            Console.WriteLine();
            string sentence = method.Concatination("Good", "Morning");
            Console.WriteLine(sentence);
            int a = 10;
            int b = 10;

            Console.WriteLine($"original values: {a}");
            Console.WriteLine($"original value {b}\n");


            Console.WriteLine($"returned {method.Ref_addition(a)}");
            Console.WriteLine($"returned {method.Ref_subtraction(ref b)}\n");

            Console.WriteLine($"original values: {a}");
            Console.WriteLine($"original value {b}");


        }
    }
}
