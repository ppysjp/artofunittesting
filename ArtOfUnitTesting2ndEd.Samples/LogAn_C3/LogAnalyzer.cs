using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn_C3
{
    public class LogAnalyzer
    {
        private IExtensionManager _manager;

        public LogAnalyzer(IExtensionManager mgr)
        {
            _manager = mgr;
        }

        public bool IsValidLogFileName (string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }


}
