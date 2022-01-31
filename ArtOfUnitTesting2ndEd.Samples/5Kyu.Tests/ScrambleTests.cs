using System;
using _5kyu;
using NUnit.Framework;


namespace _5Kyu.Tests
{
    [TestFixture]
    public class ScrambleTests
    {
        private static void Testing(bool actual, bool expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Testing(ScrambleKata.Scramble("a", "a"), true);
            Testing(ScrambleKata.Scramble("a", "b"), false);
            Testing(ScrambleKata.Scramble("ab", "b"), true);
            Testing(ScrambleKata.Scramble("ab", "ab"), true);
            Testing(ScrambleKata.Scramble("ab", "ba"), true);
            Testing(ScrambleKata.Scramble("rkqodlw", "world"), true);
            Testing(ScrambleKata.Scramble("rkqodlw", "world"), true);
            Testing(ScrambleKata.Scramble("cedewaraaossoqqyt", "codewars"), true); // stuck on this one
            Testing(ScrambleKata.Scramble("katas", "steak"), false);
            Testing(ScrambleKata.Scramble("scriptjavx", "javascript"), false);
            Testing(ScrambleKata.Scramble("scriptingjava", "javascript"), true);
            Testing(ScrambleKata.Scramble("scriptsjava", "javascripts"), true);
            Testing(ScrambleKata.Scramble("javscripts", "javascript"), false);
            Testing(ScrambleKata.Scramble("aabbcamaomsccdd", "commas"), true);
            Testing(ScrambleKata.Scramble("commas", "commas"), true);
            Testing(ScrambleKata.Scramble("sammoc", "commas"), true);
        }
    }
}
