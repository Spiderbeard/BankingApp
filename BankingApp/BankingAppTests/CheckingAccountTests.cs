using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.BankingAppTests
{
    [TestClass]
   public class CheckingAccountTests
    {
        [TestMethod]
        public void CheckingAccountWithdrawTest()
        {
            //Arrange

            Checking checking = new Checking("sut", 1, 300);

            //Act
            checking.Withdraw(200);

            // Assert

            Assert.AreEqual(100, checking.balance);
        }

        [TestMethod]
        public void CheckingAccountDepositTest()
        {
            //Arrange

            Checking checking = new Checking("sut", 1, 300);

            //Act
            checking.Deposit(200);

            // Assert

            Assert.AreEqual(500, checking.balance);
        }

        [TestMethod]
        public void CheckingAccountTransferTest()
        {
            //Arrange

            Checking checkingTo = new Checking("sut", 1, 300);
            Checking checkingFrom = new Checking("sut", 2, 300);

            //Act
            checkingFrom.Transfer(checkingTo, checkingFrom, 150);

            // Assert

            Assert.AreEqual(450, checkingTo.balance);
            Assert.AreEqual(150, checkingFrom.balance);
        }
    }
}
