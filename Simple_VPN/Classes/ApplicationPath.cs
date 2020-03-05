using System;
using System.IO;

namespace Simple_VPN.Classes
{
    class ApplicationPath
    {
        public static string AppPath()
        {
            string GetDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return GetDir;
        }
    }
}
