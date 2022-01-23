using System;
using NUnit.Framework;

namespace LogAn_C3.UnitTests
{
    [TestFixture]
    public class LogAnalyzerConstructerInjectionTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            // Arrange
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillBeValid = true;
            LogAnalyzerConstructorInjection log = new LogAnalyzerConstructorInjection(myFakeManager);

            //Act
            bool result = log.IsValidLogFileName("short.ext");

            //Assert
            Assert.True(result);

        }

    }
}
