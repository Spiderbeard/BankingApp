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

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0m && amount <= balance)
            {
                balance -= amount;
            }
        }

        public  void Deposit(decimal amount)
        {
            if(amount > 0m)
            {
                balance += amount;
            }
        }

        public void Transfer(Account accountTo, Account accountFrom, decimal amount)

        {
            if(accountFrom.balance > 0 && accountFrom.balance >= amount)
            {
                accountFrom.Withdraw(amount);
                accountTo.Deposit(amount);
            }
        }
    }
}
