using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace LogAn_C3.UnitTests
{
    class ExceptionSimulationTests
    {
        [Test]
        public void IsValidFileName_NameSupportedExtension_ReturnsTrue()
        {
            FakeExtensionManager myFakeManager = new FakeExtensionManager();
            myFakeManager.WillThrow = new Exception("this is fake");
            LogAnalyzer log = new LogAnalyzer(myFakeManager);
            bool result = log.IsValidLogFileName("anything.anyextension");
            Assert.False(result);
        }
    }

    internal class LogAnalyzer
    {
        private FakeExtensionManager _manager;

        public LogAnalyzer(FakeExtensionManager manager)
        {
            _manager = manager;
        }

        internal bool IsValidLogFileName(string fileName)
        {
            //return _manager.IsValid(fileName);
            try
            {
                return _manager.IsValid(fileName);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
