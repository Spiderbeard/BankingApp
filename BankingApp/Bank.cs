using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Bank
    {
        public string Name { get; set; }

        private List<Account> accounts { get; set; } = new List<Account>();
    }
}
