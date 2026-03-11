namespace Book_BestSeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Atomic Habits", "James Clear", 650, true);
            Book book2 = new Book("Rich Dad, Poor Dad", "Robert Kiyosaki", 650, false);
            book1.DisplayInfo();
            book2.DisplayInfo();
        }
    }
}
