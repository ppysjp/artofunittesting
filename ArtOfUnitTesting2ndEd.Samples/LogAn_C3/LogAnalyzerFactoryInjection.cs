using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn_C3
{
    public class LogAnalyzerFactoryInjection : ILogAnalyzer
    {
        private IExtensionManager _manager; 

        public LogAnalyzerFactoryInjection()
        {
            _manager = ExtensionManagerFactory.Create();
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}
