using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _7kyu.Tests
{
    class DigitalSumTests
    {
        [TestCase(3, 3)]
        [TestCase(13, 3)]
        public static void LastDigit(int n, int expected)
        {
            Assert.AreEqual(expected, DigitalSumKata.LastDigit(n));
        }

        [TestCase(3, 3)]
        [TestCase(25, 7)]
        [TestCase(361, 10)]
        public static void SumDigits(int n, int expected)
        {
            Assert.AreEqual(expected, DigitalSumKata.SumDigits(n));
        }

        [TestCase(3, 3)]
        [TestCase(25, 7)]
        [TestCase(361, 1)]
        public static void DigitalSum(int n, int expected)
        {
            Assert.AreEqual(expected, DigitalSumKata.DigitalSum(n));
        }

    }
}
