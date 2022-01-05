using System;
using System.Collections.Generic;
using HigherOrderAbstractions;
using NUnit.Framework;

namespace _7kyu.Tests
{
    [TestFixture]
    public class IsSquareNumberTests
    {
        [TestCase(-1, false)]
        [TestCase(3, false)]
        [TestCase(13, false)]
        public static void IsSquare_False(int n, bool expected)
        {
            Assert.AreEqual(expected, IsSquareNumberKata.IsSquare(n), "n is not square");
        }

        [TestCase(1, true)]
        [TestCase(4, true)]
        [TestCase(16, true)]
        public static void IsSquare_True(int n, bool expected)
        {
            Assert.AreEqual(expected, IsSquareNumberKata.IsSquare(n), "4 is a square number");
        }
    }
}
