using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public abstract class  Investment : Account
    {
        public Investment(string owner, int accountNumber) : base(owner, accountNumber)
        {

        }
        public Investment(string owner, int accountNumber, decimal balance) : base(owner, accountNumber,balance)
        {

        }
    }
}
