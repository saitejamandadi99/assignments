using System.Threading.Channels;

namespace Predicate_Example
{
    internal class Program
    {

        public static Predicate<string> predicate = IsUpperCase;
        static void Main(string[] args)
        {
            Console.WriteLine("---Predicate Demo----");
            bool result = Program.predicate("Hello");
            if (result)
            {
                Console.WriteLine("Upper case");
            }
            else
            {
                Console.WriteLine("Not upper case");
            }

            Console.WriteLine("----Displaying find all using Method");
            List<int> listint = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenList = listint.FindAll(IsEven);
            foreach(int a in evenList)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("---Displaying and find all using Prediate ------");
            List<string> nameList = new List<string>() { "hello", "mono", "cept", "world", "work" };
            Predicate<string> startsWithW = name => name.StartsWith("w");
            List<string> results = nameList.FindAll(startsWithW);
            results.ForEach(Console.WriteLine);

        }

        public static bool IsUpperCase(string s)
        {
            return s.Equals(s.ToUpper());
        }

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}
