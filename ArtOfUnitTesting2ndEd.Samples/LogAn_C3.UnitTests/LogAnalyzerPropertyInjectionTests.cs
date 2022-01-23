using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LogAn_C3.UnitTests
{
    [TestFixture]
    public class LogAnalyzerPropertyInjectionTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillThrow = new Exception("This is fake");
            LogAnalyzerPropertyInjection log = new LogAnalyzerPropertyInjection();
            log.ExtensionManager = myFakeManager;

            bool result = log.IsValidLogFileName("anything.anyextension");

            Assert.False(result);

        }
    }
}
