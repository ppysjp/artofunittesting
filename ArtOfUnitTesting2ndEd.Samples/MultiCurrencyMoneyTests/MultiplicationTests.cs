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
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.amount);
        }
    }
}