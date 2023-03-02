using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class StudentLoanAccount : IAccount
    {
        public decimal CreditLimit { get; private set; }

        public StudentLoanAccount(decimal creditLimit)
        {
            CreditLimit = creditLimit;
            Transactions = new List<BankTransaction>();
        }

        public List<BankTransaction> Transactions { get; private set; }

        public decimal Balance { get; private set; }

        public string AccountType { get { return "Student Loan" } }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdrawal(decimal amount)
        {
            Balance -= amount;
        }
    }
}
