using System.Text.Json;
using System.Transactions;

namespace Serialization_DeSerialization_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accDetails = new Account();
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "accountDetails.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                accDetails = JsonSerializer.Deserialize<Account>(json);
                Console.WriteLine($"Welcome Back \nAccount Balance : {accDetails.CheckBalance():C2}");
            }
            else
            {
                
                Console.WriteLine("Creating New Account : Required Details");
                Console.WriteLine("Enter the Account No: ");
                int.TryParse(Console.ReadLine(), out int accNo);
                accDetails.AccountNo = accNo;
                Console.WriteLine("Enter the Name of The Holder");
                accDetails.AccountHolderName = Console.ReadLine();
                Console.WriteLine("Enter the Name of the Bank");
                accDetails.BankName = Console.ReadLine();
                Console.WriteLine("Enter the Balance");
                double balance;
                while (true)
                {
                    double.TryParse(Console.ReadLine(), out double money);
                    if(money > 500)
                    {
                        balance = money;
                        break;
                    }
                    Console.WriteLine("Please enter amount above 500");

                }
                    accDetails.Balance = balance;

                //serializing the data 
                string data = JsonSerializer.Serialize(accDetails);
                File.WriteAllText(filePath, data);
            }

            while (true)
            {
                Console.WriteLine("\n------Operations------\n");
                Console.WriteLine("What do you wish to do\n1.Deposit\n2.WithDraw\n3.Display Balance\n4.Exit");
                int.TryParse(Console.ReadLine(), out int option);
                switch (option)
                {

                    case 1:
                        Console.WriteLine("Enter the Amount to deposit");
                        double.TryParse(Console.ReadLine(), out double amount);
                        accDetails.DepositAmount(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Amount to withdraw");
                        double.TryParse(Console.ReadLine(), out double remove);
                        accDetails.WithDrawl(remove);
                        break;
                    case 3:
                        Console.WriteLine($"Total Balance in Account : {accDetails.AccountNo} - Balance: {accDetails.CheckBalance():C2}");
                        break;
                    case 4:
                        Console.WriteLine("Thank you! Please Visit Again");
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                string jsonData = JsonSerializer.Serialize(accDetails);
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine();
            }
        }
    }
}
