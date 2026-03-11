using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_BestSeller
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsBestSeller { get; set; }

        public Book(string title, string author, double price, bool isBestSeller)
        {
            Title = title;
            Author = author;
            Price = price;
            IsBestSeller = isBestSeller;
        }

        public double GetDiscountPrice()
        {
            double BookPrice = Price;
            if (IsBestSeller)
            {
                BookPrice = BookPrice - BookPrice * 0.1; //BookPrice *= 0.90
            }
            if(BookPrice > 500) //even if it is not best seller discount will be added
            {
                BookPrice = BookPrice -  BookPrice * 0.05; //BookPrice *= 0.95
            }
            return BookPrice;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Original Price: {Price}");
            //Console.WriteLine($"Best Seller? {IsBestSeller}");
            Console.WriteLine($"Price after Discount: {GetDiscountPrice()}");
            Console.WriteLine();

        }
    }
}
