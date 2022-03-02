using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fulbank;
using Fulbank.Model;

namespace FulbankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeposit()
        {
            float montant = 10;
            CurrentAccount testCompte = new CurrentAccount();
            testCompte.Balance = 5;
            testCompte.Deposit(montant);

            Assert.AreEqual(15,testCompte.Balance,"Deposit OK");
            //Assert.AreEqual(14, testCompte.Balance, "Deposit Fail");
        }
        [TestMethod]
        public void TestWithDrawal()
        {
            float montant = 10;
            CurrentAccount testCompte = new CurrentAccount();
            testCompte.Balance = 20;
            testCompte.Withdrawal(montant);

            Assert.AreEqual(10, testCompte.Balance, "WithDrawal OK");
        }
    }
}
