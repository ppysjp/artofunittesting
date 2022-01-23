using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LogAn_C3.UnitTests
{
    class LogAnalyzerFactoryInjectionTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;
            ExtensionManagerFactory.SetManager(myFakeManager);
            ILogAnalyzer log = new LogAnalyzerFactoryInjection();
            var result = log.IsValidLogFileName("Bob");
            Assert.True(result);
        }

    }
}
