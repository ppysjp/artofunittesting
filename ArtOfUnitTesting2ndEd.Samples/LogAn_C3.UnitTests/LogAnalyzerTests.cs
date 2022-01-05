using System;
using NUnit.Framework;

namespace LogAn_C3.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;

            LogAnalyzer log = new LogAnalyzer(myFakeManager);

            bool result = log.IsValidLogFileName("short.ext");
            Assert.True(result);
            
        }
    }

    internal class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}
