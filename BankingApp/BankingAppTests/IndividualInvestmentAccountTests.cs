using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.BankingAppTests
{
    [TestClass]
   public class IndividualInvestmentAccountTests
    {
        [TestMethod]
        public void IndividualInvestmentAccountWithdrawTest()
        {
            //Arrange
            IndividualInvestment investment = new IndividualInvestment("sut", 1, 1000);

            //Act

            investment.Withdraw(400);

            //Assert

            Assert.AreEqual(600, investment.balance);
        }

        [TestMethod]
        public void IndividualInvestmentAccountDepositTest()
        {
            //Arrange
            IndividualInvestment investment = new IndividualInvestment("sut", 1, 1000);

            //Act

            investment.Deposit(500);

            //Assert

            Assert.AreEqual(1500, investment.balance);
        }

        [TestMethod]
        public void IndivdualInvestmentAccountTransferTest()
        {
            //Arrange
            IndividualInvestment investmentTo = new IndividualInvestment("sut", 1, 1000);
            IndividualInvestment investmentFrom = new IndividualInvestment("sut", 2, 1000);

            //Act

            investmentFrom.Transfer(investmentTo, investmentFrom, 400);

            //Assert

            Assert.AreEqual(600, investmentFrom.balance);
            Assert.AreEqual(1400, investmentTo.balance);
        }

        [TestMethod]
        public void IndivdualInvestmentAccountTransferTestOver500ReturnsOrginalBalance()
        {
            //Arrange
            IndividualInvestment investmentTo = new IndividualInvestment("sut", 1, 1000);
            IndividualInvestment investmentFrom = new IndividualInvestment("sut", 1, 1000);

            //Act

            investmentFrom.Transfer(investmentTo, investmentFrom, 600);

            //Assert

            Assert.AreEqual(1000, investmentFrom.balance);
            Assert.AreEqual(1000, investmentTo.balance);
        }
    }
}
