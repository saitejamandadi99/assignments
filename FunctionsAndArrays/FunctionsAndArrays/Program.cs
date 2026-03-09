namespace FunctionsAndArrays
{
    internal class Program
    {
        public int[] checkDiscount(int[] fees)
        {
            int[] discountFee = new int[5];
            for (int i = 0; i < 5; i++)
            {
                if (fees[i] > 7000)
                {
                    int discount = fees[i] * 5 / 100;
                    discountFee[i] = fees[i] - discount;
                }
                else
                {
                    discountFee[i] = fees[i];
                }
            }

            return discountFee;
        }
        
        static void Main(string[] args)
        {
            int[] fees = new int[5];
            int index = 0;
            while (index < 5)
            {
                Console.WriteLine("Enter the fees between 5000 and 10000");
                int.TryParse(Console.ReadLine(), out int fee);
                if (!(fee >= 5000 && fee <= 10000))
                {
                    Console.WriteLine("Please enter a number b/w 5000 and 10000");
                }
                else
                {
                    fees[index] = fee;
                    index++;
                }
            }


            Program p = new Program();
            int[] discoutfees = p.checkDiscount(fees);
            foreach (int i in discoutfees) {
                Console.WriteLine($"after discount {i}");
            }

        }
    }
}
