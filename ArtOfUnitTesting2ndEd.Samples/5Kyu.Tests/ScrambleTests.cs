using System;
using _5kyu;
using NUnit.Framework;


namespace _5Kyu.Tests
{
    [TestFixture]
    public class ScrambleTests
    {

        [Test]
        public void Scramble_EmptyListArguments_ReturnsEmptyList()
        {
            Assert.True(ScrambleKata.Scramble("", ""));
        }
    }
}
