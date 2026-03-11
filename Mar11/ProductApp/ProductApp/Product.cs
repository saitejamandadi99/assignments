using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProductApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } 
        public double DiscountPercentage { get; set; }

        public Product(int id , string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price; 
            DiscountPercentage = discountPercentage;

        }

        public double GetDiscountPrice()
        {
            return Price - (Price * DiscountPercentage / 100f);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Id: {Id}");
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Price: {Price}");
            Console.WriteLine($"Product Discount Percentage: {DiscountPercentage}%");
            Console.WriteLine($"Product Price after discount: {GetDiscountPrice()}");
            Console.WriteLine();
        }
    }
}
