using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn_C3
{
    public class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;
        public Exception WillThrow = null;

        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}
