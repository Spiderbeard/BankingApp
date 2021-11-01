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

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && amount < 500)
            {
                base.Withdraw(amount);
            }
        }
    }
}
