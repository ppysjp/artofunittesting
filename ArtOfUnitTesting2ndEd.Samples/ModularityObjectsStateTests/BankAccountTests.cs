using System;
using ModularityObjectsState;
using NUnit.Framework;


namespace ModularityObjectsStateTests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void BalanceWithdraw_WithDrawalAmmountGreaterThanBalance_ThrowsInvalidArgumentException()
        {
            // Arrange
            var bankAccount = new BankAccount(100);

            // Act
            var ex = Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(125));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Cannot Withdraw. Amount must be less than balance."));
        }

        [Test]
        public void Balance100_Withdraw_25_75()
        {
            // Arrange
            var bankAccount = new BankAccount(100);
            
            // Act
            var result = bankAccount.Withdraw(25);

            // Assert
            Assert.AreEqual(75, result);
        }

        [Test]
        public void Balance100_Deposit_25_75()
        {
            // Arrange
            var bankAccount = new BankAccount(100);

            // Act
            var result = bankAccount.Deposit(25);

            // Assert
            Assert.AreEqual(125, result);
        }



    }
}
