using System;
using System.Collections.Generic;
using System.Text;
using _5kyu;
using NUnit.Framework;


namespace _5Kyu.Tests
{
    class PermutationsTests
    {

        private static void Testing(IEnumerable<string> actual, IEnumerable<string> expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Testing( PermutationsKata.Permutate("") , new List<string> {});
            Testing(PermutationsKata.Permutate("a"), new List<string> { "a" });
            Testing(PermutationsKata.Permutate("ab"), new List<string> { "ab", "ba" });

        }
    }
}
