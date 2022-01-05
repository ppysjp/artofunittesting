using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;

namespace _6kyu.Tests
{
    class IsValidWalkTests
    {

     [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void IsValidWalk_True()
        {
            Assert.AreEqual(true, IsValidWalkKata.IsValidWalk(new string[] { }), "should return true");
            Assert.AreEqual(true, IsValidWalkKata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
        }

        [Test]
        public void IsValidWalk_False()
        {
                //Assert.AreEqual(false, IsValidWalkKata.IsValidWalk(new string[] { "w" }), "should return false");
                Assert.AreEqual(false, IsValidWalkKata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
                //Assert.AreEqual(false, IsValidWalkKata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
         }
    }
}
}
