using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _7kyu.Tests
{
    [TestFixture]
    class BinaryToDecimalTests
    {

        [TestCase("0", 0)]
        [TestCase("1", 1)]
        [TestCase("10", 2)]
        [TestCase("101", 5)]        
        [TestCase("1010101", 85)]
        public static void BinaryToDecimal(string n, int expected)
        {
            var result = BinaryToDecimalKata.BinaryToDecimal(n);
            Assert.AreEqual(expected, result);
        }
    }
}
