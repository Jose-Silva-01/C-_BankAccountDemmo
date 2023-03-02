using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankTransaction
    {
        public BankTransaction(TransactionType type, decimal amount)
        {
            this.Type = type;
            this.Amount = amount;
        }

        public decimal Amount { get; private set; }

        public TransactionType Type { get; private set; }

        public string DisplayAmount
        {
            get
            {
                return Type.ToString() + ": " + Amount.ToString("c");
            }
        }
    }
}
