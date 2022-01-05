using System;
using NUnit.Framework;

namespace LogAn_copy.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {

        // We could make the below test even more generic by uncommenting the below lines and replace the 
        // the name of the test but this would make things more generic and less easy to see what the test was
        // actually testing.

        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        //[TestCase("filewithgoodextension.foo", false)]
        public void IsValidFileName_ValidExtensions_ReturnsTrue(string file, bool expected)
        //public void IsValidFileName_ValidExtensions_ChecksThem(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            Assert.AreEqual(expected,result);
        }

        [Test]
        public void IsValidFileName_EmptyFileName_Throws()
        {
            LogAnalyzer la = MakeAnalyzer();

            var ex = Assert.Catch<Exception>(() => la.IsValidLogFileName(string.Empty));

            StringAssert.Contains("filename has to be provided", ex.Message);
        }

        [TestCase("badfile.foo", false)]
        [TestCase("goodfile.slf", true)]
        public void IsValidFileName_WhenCalled_ChangesWasLastFileNameValid(string file, bool expected)
        {
            LogAnalyzer la = MakeAnalyzer();

            la.IsValidLogFileName(file);

            Assert.AreEqual(expected, la.WasLastFileNameValid);
            
        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
    }
}
