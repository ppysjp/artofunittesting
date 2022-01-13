using System;
using NUnit.Framework;

namespace _7kyu.Tests
{
    [TestFixture]
    public class AddBinaryTest
    {
        [Test]
        public void AddBinary()
        {
            Assert.AreEqual("11", BinaryAdditionKata.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }

        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(2, 10)]
        [TestCase(3, 11)]
        [TestCase(85, 1010101)]
        public void IntToBinary(int a, int result)
        {
            Assert.AreEqual(result, BinaryAdditionKata.IntToBinary(a));
        }

    }
}
