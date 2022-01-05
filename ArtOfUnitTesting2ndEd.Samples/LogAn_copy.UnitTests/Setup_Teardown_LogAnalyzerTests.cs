using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LogAn_copy.UnitTests
{
    [TestFixture]
    class Setup_Teardown_LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidFileName_validFileLowerCased_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatever.slf");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [Test]
        public void IsValidFileName_validFileUpperCased_ReturnsTrue()
        {
            bool result = m_analyzer.IsValidLogFileName("whatver.SLF");

            Assert.IsTrue(result, "filename should be valid!");
        }

        [TearDown]
        public void TearDown()
        {
            // This line isn't needed in real life because it is sorted by the garbage collection. 

            m_analyzer = null;
        }
    }
}
