namespace Bank_Game_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount("Ajay", 20000);
            BankAccount bank2 = new BankAccount("Vijay", 22000);
            Random random = new Random();

            bank1.Deposit(random.Next(1000, 5000));
            bank2.Deposit(random.Next(1000, 5000));

            bank1.WithDraw(random.Next(1000, 5000));
            bank2.Deposit(random.Next(1000, 5000));

            bank1.Deposit(random.Next(1000, 5000));
            bank2.WithDraw(random.Next(1000, 5000));

            if(bank1.GetBalance() > bank2.GetBalance())
            {
                Console.WriteLine("Ajay is winner");
            }
            else if(bank1.GetBalance() < bank2.GetBalance())
            {
                Console.WriteLine("Vijay is winner");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }

        }
    }
}
