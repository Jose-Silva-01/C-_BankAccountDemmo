using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class SavingsAccount : BankAccount
    {
        // this private before the set makes sure that we can only set the property inside this class
        public int NumberOfDeposits { get; private set; }

        // this will pass the value to the base constructor
        public SavingsAccount(decimal balance) : base(balance)
        {
        }

        //We can override things in the new class
        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);

            NumberOfDeposits++;
        }

        public override string AccountType
        {
            get
            {
                return "Savigns Account";
            }
        }

        public override void Withdrawal(decimal amount)
        {
            if(amount > this.Balance)
            {
                throw new Exception("Insufficient Funds");
            }

            base.Withdrawal(amount);
        }

        public override string GetAccountDisplay()
        {
            return $"Your Balance is for your Chequing Account {this.Balance.ToString("c")}";
        }
    }
}
