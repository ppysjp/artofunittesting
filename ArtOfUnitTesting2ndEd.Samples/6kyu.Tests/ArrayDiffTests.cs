using System;
using NUnit.Framework;

namespace _6kyu.Tests
{

    [TestFixture]
    public class ArrayDiffTests
    {
        [Test]
        public void ArrayDiff_EmptyListArguments_ReturnsEmptyList()
        {
            Assert.AreEqual(new int[] { }, ArrayDiffKata.ArrayDiff(new int[] { }, new int[] { }));
        }

        [Test]
        public void ArrayDiff_bIsEmpty_Returnsa()
        {
            Assert.AreEqual(new int[] { 1, 2 }, ArrayDiffKata.ArrayDiff(new int[] {1, 2}, new int[] { }));
        }

        [Test]
        public void ArrayDiff_bContainsOneValue_ReturnsaLessOneValue()
        {
            Assert.AreEqual(new int[] { 2 }, ArrayDiffKata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
        }


        [Test]
        public void Rest_Of_Tests()
        {
            Assert.AreEqual(new int[] { 2, 2 }, ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, ArrayDiffKata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 3 }, ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }
    }
}
