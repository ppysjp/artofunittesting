using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn_C3
{
    public interface ILogAnalyzer
    {
        public bool IsValidLogFileName(string fileName);
    }
}
