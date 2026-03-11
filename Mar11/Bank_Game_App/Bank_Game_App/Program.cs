namespace Bank_Game_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            BankAccount bank1 = new BankAccount("Ajay", random.Next(10000,50000));
            BankAccount bank2 = new BankAccount("Vijay", random.Next(10000,50000));
            

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
