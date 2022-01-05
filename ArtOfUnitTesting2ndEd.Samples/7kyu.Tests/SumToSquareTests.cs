using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _7kyu.Tests
{
    class SumToSquareKataTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(3, 9)]
        public static void Square_N(int n, int expected)
        {
            Assert.AreEqual(expected, SumToSquareKata.Square(n));
        }

        [TestCase(1,1,1)]
        [TestCase(1,2,4)]
        [TestCase(1,3,9)]
        public static void Sum2kMinus1_k1n1_One(int i, int n, int expected)
        {
            Assert.AreEqual(expected, SumToSquareKata.Sum2kMinus1(i, n));
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 3)]
        public static void SumK_One_Two_Identity_PlusOne(int i, int n, int expected)
        {
            Assert.AreEqual(expected, SumToSquareKata.SumTerm(i, n, k => k, inc => inc + 1));
        }
    }
}
