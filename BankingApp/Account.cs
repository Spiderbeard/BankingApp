using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    // abstract so it cant be instatiated 
    public abstract class Account
    {
        private string owner { get; }

        // For differnating accounts for transfer
        private int accountNumber { get; }

        //can access balance but only set it using the methods
        public decimal balance { get; private set; }
        
        //constuctor with no starting balance
        public Account(string owner, int accountNumber)
        {
            this.owner = owner;
            this.accountNumber = accountNumber;
            balance = 0m;
        }
        //constuctor with starting balance
        public Account(string owner, int accountNumber, decimal balance)
        {
            this.owner = owner;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        // virtual so subclasses can impliment the base or override 
        public virtual decimal Withdraw(decimal amount)
        {
            if (amount > 0m && amount <= balance)
            {
                balance -= amount;
                
            }
            return balance;
        }

        // must use base 
        public decimal Deposit(decimal amount)
        {
            if(amount > 0m)
            {
                balance += amount;

            }
            return balance;
        }

        public virtual int Transfer(Account accountTo, Account accountFrom, decimal amount)

        {
            if(amount > 0 && accountFrom.balance >= amount && accountFrom.accountNumber != accountTo.accountNumber)
            {
                accountFrom.Withdraw(amount);
                accountTo.Deposit(amount);
                return 1;
            }
            return -1;
        }
    }
}
