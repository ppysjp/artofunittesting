using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn_C3
{
    public class AlwaysValidFakeExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return true;
        }
    }
}
