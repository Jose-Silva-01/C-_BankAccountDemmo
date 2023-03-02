using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    interface IAccount : IWithdraw, IDeposit
    {
        // The Interface lets you inherit more than one interface
        //Again, you don't implement nothing on it, it just means that everything that inherit this will
        //need to to have it
        decimal Balance { get; }

        List<BankTransaction> Transactions { get; }
        
        string AccountType { get; }
    }
}
