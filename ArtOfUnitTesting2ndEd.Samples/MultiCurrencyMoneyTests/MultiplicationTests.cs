using NUnit.Framework;
using MultiCurrencyMoney;

namespace MultiCurrencyMoneyTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDollarAmount()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(5, five.Amount);

        }

        [Test]
        public void TestDollarMultiplication()
        {
            Dollar five = new Dollar(5);     
            Assert.AreEqual(new Dollar(10), five.Times(2));      
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }

        [Test]
        public void TestDollarEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));

        }
    }
}