using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class ChequingAccount : BankAccount
    {
        public decimal TransactionFee { get; private set; }
        public int NumberOfWithdrawal { get; private set; }

        public override string AccountType
        {
            get
            {
                return "Chequing account";
            }
        }

        public ChequingAccount(decimal balance) : base(balance)
        {
            TransactionFee = 1;
        }

        // So in this example, since the accountNumber is protected I couldn't change
        // in the console app but since this class is an inherited class I can change
        // it.
        public ChequingAccount(decimal balance, string accountNumber) : base(balance)
        {
            this.AccountNumber = accountNumber;
            TransactionFee = 1;
        }

        // with this we can still use the old withdrawal plus some implementation
        public override void Withdrawal(decimal amount)
        {
            if(amount + TransactionFee > this.Balance)
            {
                throw new Exception("Insufficient funds after transaction fee");
            }

            base.Withdrawal(amount);

            NumberOfWithdrawal++;
        }

        public override string GetAccountDisplay()
        {
            return $"Your Balance is for your Chequing Account {this.Balance.ToString("c")}" ;
        }
    }
}
