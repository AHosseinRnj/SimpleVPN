using System.Net;

namespace Simple_VPN.Classes
{
    class ConnectionChecker
    {
        public static bool InternetConnectionChecker()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
