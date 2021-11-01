using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    class CorprateInvestment : Investment
    {
        public CorprateInvestment(string owner, int accountNumber) : base(owner, accountNumber)
        {

        }

        public CorprateInvestment(string owner, int accountNumber, decimal balance) : base(owner, accountNumber, balance)
        {

        }
    }
}
