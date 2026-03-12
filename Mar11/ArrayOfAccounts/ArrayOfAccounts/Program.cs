using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace ArrayOfAccounts
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Account[] AccountsArray = new Account[3];
            int choice;
            int count=0;

            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: \n");
                string accountNumber;
                bool found;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("invalid choice");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        if (count < AccountsArray.Length)
                        {
                            AccountsArray[count] = new Account();
                            Console.WriteLine("Please enter the details to create account");
                            AccountsArray[count].CreateAccount();
                            Console.WriteLine($"User created successfully with Number :{AccountsArray[count].AccountNumber}\n");
                            count++;
                            break;
                        }
                        Console.WriteLine("Could not create a account! Limit reached");
                        break;

                    case 2:
                        Console.WriteLine("Please enter the Account Number");
                        accountNumber = Console.ReadLine();
                        found = false;
                        foreach (var account in AccountsArray)
                        {
                            if (account != null && account.AccountNumber == accountNumber)
                            {
                                Console.WriteLine($"Account Balance with {accountNumber} has {account.GetBalance()} ");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine($"Could not find the account with account number: {accountNumber}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Please enter the Account Number");
                        accountNumber = Console.ReadLine();
                        Console.WriteLine("Enter the amount to deposit");
                        double.TryParse(Console.ReadLine(), out double depositAmount);
                        found = false;
                        foreach (var account in AccountsArray)
                        {
                            if (account != null && account.AccountNumber == accountNumber)
                            {
                                account.Deposit(depositAmount);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine($"Could not find the account with account number: {accountNumber}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Please enter the Account Number");
                        accountNumber = Console.ReadLine();
                        Console.WriteLine("Enter the amount to Withdraw");
                        double.TryParse(Console.ReadLine(), out double withdrawAmount);
                        found = false;
                        foreach (var account in AccountsArray)
                        {
                            if (account != null && account.AccountNumber == accountNumber)
                            {
                                account.WithDraw(withdrawAmount);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine($"Could not find the account with account number: {accountNumber}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default: 
                        Console.WriteLine("Invalid choice");
                        break;
                }



            }
            while (choice != 5);
            Console.WriteLine("Thank you");
        }
    }
}
