using System;

namespace LogAn_C3
{
    public class LogAnalyzerConstructorInjection : ILogAnalyzer
    {
        private IExtensionManager _manager;

        public LogAnalyzerConstructorInjection(IExtensionManager manager)
        {
            _manager = manager;
        }

        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
}