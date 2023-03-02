using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(0);
            ChequingAccount chequingAccount = new ChequingAccount(0);
            BankAccount currentAccount;
            string menu
                = " 1 Chequing Account" + Environment.NewLine +
                " 2 SavingsAccount" + Environment.NewLine +
                " 3 exit";
            int choice = getChoice(menu);
            while (choice != 3)
            {
                try
                {
                    if (choice == 1)
                    {
                        currentAccount = chequingAccount;
                    }
                    else if (choice == 2)
                    {
                        currentAccount = savingsAccount;
                    }
                    else
                    {
                        throw new Exception("Invalid Choice");
                    }
                    ProcesssTransation(currentAccount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                choice = getChoice(menu);
            }
            Console.ReadKey();
        }
        private static void ProcesssTransation(BankAccount account)
        {
            string menu = " 1 Deposit" + Environment.NewLine +
                            " 2 Withrawal " + Environment.NewLine +
                            " 3 Balance " + Environment.NewLine +
                            "4 Display Transactions" + Environment.NewLine +
                            " 5 Exit " + Environment.NewLine;
            int choice = getChoice(menu);
            while (choice != 5)
            {
                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Amount to Deposit");
                            string depositAmount = Console.ReadLine();
                            account.Deposit(Convert.ToDecimal(depositAmount));
                            Console.WriteLine("Balance: ");
                            Console.WriteLine(account.Balance);
                            break;
                        case 2:
                            Console.WriteLine("Amount to Withdraw");
                            string withdrawAmount = Console.ReadLine();
                            account.Withdrawal(Convert.ToDecimal(withdrawAmount));
                            Console.WriteLine("Balance: ");
                            Console.WriteLine(account.Balance);
                            break;
                        case 3:
                            Console.WriteLine("Balance: ");
                            Console.WriteLine(account.Balance);
                            break;
                        case 4:
                            Console.WriteLine("Transactions");
                            foreach (var transaction in account.Transactions)
                            {
                                Console.WriteLine(transaction.DisplayAmount);
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                choice = getChoice(menu);
            }
        }

        private static void ProcessWithdrawal(IWithdraw account)
        {
            Console.WriteLine("Amount to Withdraw");
            string withdrawAmount = Console.ReadLine();
            decimal amount = Convert.ToDecimal(withdrawAmount);
            account.Withdrawal(amount);
        }

        private static void ProcessDeposit(IDeposit account)
        {
            Console.WriteLine("Amount to Withdraw");
            string depoisitAmount = Console.ReadLine();
            decimal amount = Convert.ToDecimal(depoisitAmount);
            account.Deposit(amount);
        }

        private static void DisplayDetails(BankAccount account)
        {
            if(account is ChequingAccount)
            {
                ChequingAccount chequingAccount = (ChequingAccount)account;
                Console.WriteLine("Number of Withdrawls " + chequingAccount.NumberOfWithdrawal);
            }
            else if(account is SavingsAccount)
            {
                SavingsAccount savingsAccount = (SavingsAccount)account;
                Console.WriteLine("Number of Withdrawls " + savingsAccount.NumberOfDeposits);
            }
        }
        private static int getChoice(string prompt)
        {
            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid Selection");
                return getChoice(prompt);
            }
        }
    }
}
