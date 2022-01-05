using System;
using NUnit.Framework;

namespace _6kyu.Tests
{
    [TestFixture]
    public class BitCountingTests
    {
        [Test]
        public void CountBits_InputZero_ReturnsZero()
        {
            Assert.AreEqual(0, CountBitsKata.CountBits(0));
        }

        [Test]
        public void CountBits_InputFour_ReturnsOne()
        {
            Assert.AreEqual(1, CountBitsKata.CountBits(4));
        }

        [Test]
        public void CountBits_InputSeven_ReturnsThree()
        {
            Assert.AreEqual(3, CountBitsKata.CountBits(7));
        }

        [Test]
        public void CountBits_InputNine_ReturnsTwo()
        {
            Assert.AreEqual(2, CountBitsKata.CountBits(9));
        }
    }
}
