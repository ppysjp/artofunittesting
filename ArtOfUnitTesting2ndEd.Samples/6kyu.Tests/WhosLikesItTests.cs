using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace _6kyu.Tests
{
    [TestFixture]
    class WhosLikesItTests
    {
        [Test, Description("It should return correct text")]
        public void Like_ListOfNames_CorrectlyFormatted()
        {
            Assert.AreEqual("no one likes this", WhoLikesItKata.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", WhoLikesItKata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", WhoLikesItKata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", WhoLikesItKata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", WhoLikesItKata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
            Assert.AreEqual("Alex, Jacob and 3 others like this", WhoLikesItKata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max", "John"}));
        }
    }
}