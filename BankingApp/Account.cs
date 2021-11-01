using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Account
    {
        private string owner { get; }

        private int accountNumber { get; }


        public decimal balance { get; private set; }

        public Account(string owner, int accountNumber)
        {
            this.owner = owner;
            this.accountNumber = accountNumber;
            balance = 0m;
        }

        public Account(string owner, int accountNumber, decimal balance)
        {
            this.owner = owner;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public virtual decimal Withdraw(decimal amount)
        {
            if (amount > 0m && amount <= balance)
            {
                balance -= amount;
                
            }
            return balance;
        }

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
