using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.BankingAppTests
{
    [TestClass]
   public class AccountTests
    {
        [TestMethod]

        public void WithdrawFromAccountReturnCorrectBalance()
        {
            // Arrange 

            Account account = new Account("test", 5, 5000);

            // Act

            account.Withdraw(4500);

            // Assert

            Assert.AreEqual(500, account.balance);
        }
        [TestMethod]

        public void DepositToAccountReturnsCorrectBalance()
        {
            // Arrange 

            Account account = new Account("SUT", 5, 300);

            // Act

            account.Deposit(200);

            // Assert

            Assert.AreEqual(500, account.balance);
        }

        [TestMethod]
        public void TransferOfMoneyReturnsAccountBalancesAreCorrect()
        {
            // Arrange
            Account accountFrom = new Account("SUT", 3, 1000);
            Account accountTo = new Account("SU", 1, 250);

            // Act
            accountFrom.Transfer(accountTo, accountFrom, 750);

            //Assert

            Assert.AreEqual(1000, accountTo.balance);
           


        }
    }
}
