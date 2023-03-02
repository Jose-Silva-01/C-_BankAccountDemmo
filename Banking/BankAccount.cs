using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public abstract class BankAccount :IAccount
    {
        //You can't instantiate an abstract class, if you create a "child class" you
        // MUST override everything that is abstract inside of the class.

        // It's good when you want to implement different usages to different functions
        // inside classes that inherit BankAccount
        public BankAccount(decimal balance)
        {
            this.Balance = balance;
            Transactions = new List<BankTransaction>();
        }

        public List<BankTransaction> Transactions { get; private set; }

        // The protected set means that we can't write it from outside of this
        // class. What makes it different than private? You get access to the 
        // protected thing from inside of an inherited class!!! 
        public string AccountNumber { get; protected set; }

        //An abstract method needs to be defined like an autoproperty but we don't need
        // to define what it does
        public abstract string AccountType{ get; }


        public decimal Balance { get; private set; }

        // virtual means that it can be changed 
        public virtual void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new Exception("Can't deposit negative amount");

            Balance += amount;
            Transactions.Add(new BankTransaction(TransactionType.Deposit, amount));
        }

        public virtual void Withdrawal(decimal amount)
        {
            if (amount < 0)
                throw new Exception("Can't withdraw negative amount");

            Balance -= amount;

            Transactions.Add(new BankTransaction(TransactionType.Withdrawal, amount));
        }

        //This is an abstract function, it means that every other class that inherit this
        // bankaccount class will need to override this abstract function
        public abstract string GetAccountDisplay();
    }
}
