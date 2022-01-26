using System;
using System.Collections.Generic;
using System.Text;
using ModularityObjectsState;
using NUnit.Framework;

namespace ModularityObjectsStateTests
{
    [TestFixture]
    public class FunctionalBankAccountTests
    {

        [Test]
        public void NewWithdraw_25_75()
        {

            // Arrange
            // Every Account here is initialized with a start balance of 100
            var bankAccount = FunctionalBankAccount.NewWithdraw();

            // Act
            var result1 = bankAccount(25);

            // Assert
            Assert.AreEqual(75, result1);

        }

        [Test]
        public void MakeWithdraw_25_75()
        {
            // Arrange
            // Here the Account can have it's balance set to a value.
            // Both have starting values of 100 in this case.
            var withdrawOnlyAccount1 = FunctionalBankAccount.MakeWithdraw(100);
            var withdrawOnlyAccount2 = FunctionalBankAccount.MakeWithdraw(100);

            // Act

            var result1 = withdrawOnlyAccount1(50);
            var result2 = withdrawOnlyAccount2(30);
            var result3 = withdrawOnlyAccount2(30);

            // Assert
            Assert.AreEqual(50, result1);
            Assert.AreEqual(70, result2);
            Assert.AreEqual(40, result3);

            // This demonstrates how you can create a function that has state within it. A partial function shall we say.
        }

        [Test]
        public void MakeAccount_25_75()
        {
            // Arrange
            var bankAccount = FunctionalBankAccount.MakeAccount(100);
           
            // Act
            var result1 = bankAccount["Withdraw"](50);

            var result2 = bankAccount["Deposit"](50);
      
            // Assert
            Assert.AreEqual(50, result1);
            Assert.AreEqual(100, result2);
        }
    }
}
