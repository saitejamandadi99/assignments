namespace FuncDelegateExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> calculateDiscount = price =>
            {
                if (price > 1000)
                {
                    return price * 0.15;
                }
                else
                {
                    return price * 0.05;
                }
            };

            Func<double, double, double> CalculateFinalPrice = (price, discount) =>
            {
                return price - discount;
            };

            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Calculate discount
            double discount = calculateDiscount(price);

            // Calculate final price
            double finalPrice = CalculateFinalPrice(price, discount);

            // Output
            Console.WriteLine($"Original Price: {price}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Final Price: {finalPrice}");
        }
    }
}
