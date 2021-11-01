using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
   public class Checking : Account
    {
        public Checking(string owner, int accountNumber) : base(owner, accountNumber )
        {

        }
        public Checking(string owner, int accountNumber, decimal balance) : base(owner, accountNumber, balance)
        {

        }

      
    }
}
