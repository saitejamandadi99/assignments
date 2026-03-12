using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfAccounts
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        private double Balance { get; set; }
        public string AccountType { get; set; }
        static Random random = new Random(); //to not allow duplicates 
        public Account() { }
        public Account(string accountNumber, string name, double balance, string accountType)
        {
            AccountNumber = accountNumber;
            Name = name;
            Balance = balance;
            AccountType = accountType;
        }

        public void CreateAccount()
        {
            AccountNumber = "IDBI" + random.Next(100000000,999999999);

            Console.WriteLine("Enter the Name of the User");
            Name = Console.ReadLine();
            Console.WriteLine();

            Balance = 500; //minimum balance

            Console.WriteLine("Enter the type of account Saving/Current");
            AccountType = Console.ReadLine();

        }

        public string GetBalance() { return Balance.ToString("C2"); }

        public void Deposit(double amount) 
        {
            Balance += amount;
            Console.WriteLine($"money deposited in the account, Total Balance : {GetBalance()}");
        }

        public void WithDraw(double amount) 
        {
            if((Balance - amount) >= 500)
            {
                Balance -= amount;
                Console.WriteLine($"Amount withdraw completed , Total Balance : {GetBalance()}");
                return;
            }
            Console.WriteLine("Minimum Balance required 500rs ");
        
        }

    }
}
