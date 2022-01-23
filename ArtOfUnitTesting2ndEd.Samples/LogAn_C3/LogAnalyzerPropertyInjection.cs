using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn_C3
{
    public class LogAnalyzerPropertyInjection : ILogAnalyzer
    {
        private IExtensionManager _manager;

        public LogAnalyzerPropertyInjection()
        {
        }

        public IExtensionManager ExtensionManager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}
