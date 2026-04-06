using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_DeSerialization_Example
{
    public class Account
    {
        public int AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public Account() { }
        public Account(int accNo, string name, string bankName, double balance)
        {
            AccountNo = accNo;
            AccountHolderName = name;
            BankName = bankName;
            Balance = balance;
        }

        public void DepositAmount(double amount)
        {
            Balance += amount;
            Console.WriteLine("Amount Deposited");
            Console.WriteLine($"Amount {amount:C2} added to Account , Total Balance: {CheckBalance():C2}");
        }

        public void WithDrawl(double amount)
        {
            if(Balance - amount >= 500)
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn");
                Console.WriteLine($"Total Balance : {CheckBalance():C2}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance! Minimum Balance Required");
                Console.WriteLine($"Total Balance : {CheckBalance():C2}");

            }
        }

        public double CheckBalance()
        {
            return Balance;
        }
    }
}
