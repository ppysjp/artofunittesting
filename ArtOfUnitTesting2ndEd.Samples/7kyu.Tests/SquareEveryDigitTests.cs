using NUnit.Framework;

namespace _7kyu.Tests
{
    [TestFixture]
    public class SquareEveryDigitKataTest
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(11, 11)]
        [TestCase(12, 14)]
        [TestCase(31, 91)]
        [TestCase(31, 91)]
        [TestCase(41, 161)]
        [TestCase(2, 4)]
        [TestCase(22, 44)]
        [TestCase(5, 25)]
        [TestCase(15, 125)]
        [TestCase(55, 2525)]
        [TestCase(9119, 811181)]
        public void SquareDigitsTest(int n, int expected)
        {
            Assert.AreEqual(expected, SquareEveryDigitKata.SquareDigits(n));
        }
    }
}
