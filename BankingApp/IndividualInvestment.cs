using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class IndividualInvestment: Investment
    {

        public IndividualInvestment(string owner, int accountNumber): base(owner, accountNumber)
        {

        }

        public IndividualInvestment(string owner, int accountNumber, decimal balance) : base(owner, accountNumber, balance)
        {

        }

        public override decimal Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= 500)
            {
                base.Withdraw(amount);
            }
            return balance;
        }

        public override int Transfer(Account accountTo, Account accountFrom, decimal amount)
        {
            if(amount <= 500)
            {
                 base.Transfer(accountTo, accountFrom, amount);
                return 1;
            }

            return -1;


           
        }
    }
}
