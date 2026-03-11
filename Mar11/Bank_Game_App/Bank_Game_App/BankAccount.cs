using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Game_App
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public double GetBalance() { return Balance; }

        public void Deposit(double money) 
        {
            Balance += money;
            Console.WriteLine($"Money deposited in {AccountHolder}'s account, Total Balance: {Balance}\n");
        }

        public void WithDraw(double amount)
        { 
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance\n");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Amount withdraw completed , Total Balance: {Balance}\n");

        }

    }

}
