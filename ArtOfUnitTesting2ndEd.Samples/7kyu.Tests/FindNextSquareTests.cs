using NUnit.Framework;
using System;

namespace _7kyu.Tests
{
    [TestFixture]
    class FindNextSquareTests
    {
        [TestCase(155,-1)]
        [TestCase(121,144)]
        [TestCase(625,676)]
        [TestCase(319225,320356)]
        [TestCase(15241383936,15241630849)]
        public static void FixedTest(long num, long expected)
        {
            Assert.AreEqual(expected, FindNextSquareKata.FindNextSquare(num));
        }

        [TestCase(1, 1)]
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        public static void Sqrt_Test(long num, long expected)
        {
            Assert.AreEqual(expected, FindNextSquareKata.Sqrt(num));
        }

    }
}
