using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    // abstract so it cant be instatiated 
    public abstract class Account
    {
        private string Owner { get; }

        // For differnating accounts for transfer
        private int AccountNumber { get; }

        //can access balance but only set it using the methods
        public decimal Balance { get; private set; }
        
        //constuctor with no starting balance
        public Account(string owner, int accountNumber)
        {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = 0m;
        }
        //constuctor with starting balance
        public Account(string owner, int accountNumber, decimal balance)
        {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        // virtual so subclasses can impliment the base or override 
        public virtual decimal Withdraw(decimal amount)
        {
            if (amount > 0m && amount <= Balance)
            {
                Balance -= amount;
                
            }
            return Balance;
        }

        // must use base 
        public decimal Deposit(decimal amount)
        {
            if(amount > 0m)
            {
                Balance += amount;

            }
            return Balance;
        }

        public virtual int Transfer(Account accountTo, Account accountFrom, decimal amount)

        {
            if(amount > 0 && accountFrom.Balance >= amount && accountFrom.AccountNumber != accountTo.AccountNumber)
            {
                accountFrom.Withdraw(amount);
                accountTo.Deposit(amount);
                return 1;
            }
            return -1;
        }
    }
}
