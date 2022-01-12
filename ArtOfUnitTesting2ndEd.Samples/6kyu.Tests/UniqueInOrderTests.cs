using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace _6kyu.Tests
{
    [TestFixture]
    public class UniqueOrderTests
    {
        [Test]
        public void UniqueInOrder_EmptyString_EmptyString()
        {
            Assert.AreEqual("", UniqueInOrderKata.UniqueInOrder(""));
        }
        [Test]
        public void UniqueInOrder_DuplicateIntArray_UniqueIntArray()
        {
            //Assert.AreEqual("ABCDAB", UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB"));
            Assert.AreEqual(new List<int> {1,2,3}, UniqueInOrderKata.UniqueInOrder(new int[] {1,2,2,3,3}));
        }

        [TestCase("AAAABBBCCDAABBB", "ABCDAB")]
        public void UniqueInOrder_DuplicateCharString_UniqueCharString(string duplicateCharString, string expected)
        {
            var uniqueCharString = UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB");
            Assert.AreEqual(expected, uniqueCharString);

        }
    }
}
