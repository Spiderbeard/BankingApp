using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.BankingAppTests
{
    [TestClass]
    public class InvestmentAccountTests
    {
        [TestMethod]
        public void InvestmentAccountWithdrawTest()
        {
            //Arrange
            Investment investment = new Investment("sut", 1, 1000);

            //Act

            investment.Withdraw(500);

            //Assert

            Assert.AreEqual(500, investment.balance);
        }

        [TestMethod]
        public void InvestmentAccountDepositTest()
        {
            //Arrange
            Investment investment = new Investment("sut", 1, 1000);

            //Act

            investment.Deposit(500);

            //Assert

            Assert.AreEqual(1500, investment.balance);
        }

        [TestMethod]
        public void InvestmentAccountTransferTest()
        {
            //Arrange
            Investment investmentTo = new Investment("sut", 1, 1000);
            Investment investmentFrom = new Investment("sut", 2, 1000);

            //Act

            investmentFrom.Transfer(investmentTo,investmentFrom,500);

            //Assert

            Assert.AreEqual(500, investmentFrom.balance);
            Assert.AreEqual(1500, investmentTo.balance);
        }
    }
}
