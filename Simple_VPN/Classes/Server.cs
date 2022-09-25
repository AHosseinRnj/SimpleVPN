using System.Collections.Generic;

namespace Simple_VPN.Classes
{
    static class Server
    {
        private static readonly Dictionary<string, string> _server = new Dictionary<string, string>();

        public static void Initialize()
        {
            _server.Add("France", "fr.s4m.xyz");
            _server.Add("Canada", "ca.s4m.xyz");
            _server.Add("Germany", "de.s4m.xyz");
            _server.Add("Argentina", "ar.s4m.xyz");
            _server.Add("Netherlands", "nl.s4m.xyz");
            _server.Add("United States", "us.s4m.xyz");
            _server.Add("Russian Federation", "ru.s4m.xyz");
        }

        public static string GetIp(string key)
        {
            return _server[key];
        }
    }
}