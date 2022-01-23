using System;

namespace LogAn_C3
{
    public class ExtensionManagerFactory
    {
        private static IExtensionManager _manager = null;

        public static IExtensionManager Create()
        {
            if (_manager != null)
            {
                return _manager;
            }
            return new FileExtensionManager();
        }

        public static void SetManager(IExtensionManager mgr)
        {
            _manager = mgr;
        }


    }
}