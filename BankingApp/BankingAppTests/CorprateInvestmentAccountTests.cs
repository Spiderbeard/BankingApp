using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.BankingAppTests
{
    [TestClass]
   public class CorprateInvestmentAccountTests
    {
        [TestMethod]
        public void CorprateInvestmentAccountWithdrawTest()
        {
            //Arrange
            CorprateInvestment investment = new CorprateInvestment("sut", 1, 1000);

            //Act

            investment.Withdraw(500);

            //Assert

            Assert.AreEqual(500, investment.balance);
        }

        [TestMethod]
        public void CorprateInvestmentAccountDepositTest()
        {
            //Arrange
            CorprateInvestment investment = new CorprateInvestment("sut", 1, 1000);

            //Act

            investment.Deposit(500);

            //Assert

            Assert.AreEqual(1500, investment.balance);
        }

        [TestMethod]
        public void CorprateInvestmentAccountTransferTest()
        {
            //Arrange
            CorprateInvestment investmentTo = new CorprateInvestment("sut", 1, 1000);
            CorprateInvestment investmentFrom = new CorprateInvestment("sut", 2, 1000);

            //Act

            investmentFrom.Transfer(investmentTo, investmentFrom, 500);

            //Assert

            Assert.AreEqual(500, investmentFrom.balance);
            Assert.AreEqual(1500, investmentTo.balance);
        }
    }
}
