namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Apple Macbook", 65000, 20);
            Product product2 = new Product(2, "Samsung Galaxy", 123000, 30);
            product1.DisplayInfo();
            product2.DisplayInfo();

        }
    }
}
