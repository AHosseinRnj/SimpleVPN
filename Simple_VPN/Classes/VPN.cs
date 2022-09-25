using System.Net;
using DotRas;

namespace Simple_VPN.Classes
{
    static class Vpn
    {
        /* 
        * The Below Username & Password Valid Till : Monday, 10 October 2022.
        *       
        * _adapterName : You can choose whatever you like.
        * 
        * _userName : Your username & _passWord : Your password.
        * _preSharedKey : Your PreSharedKey if needed.
        * 
        * You can set/add your server addresses in Classes/Server.cs .
        * 
        */

        public static string ServerIp = string.Empty;
        public static string VpnProtocol = string.Empty;

        private static string _adapterName = "SimpleVPN";
        private static string _userName = "ja.ck.quel.i.n.e.ba.netmp@gmail.com";
        private static string _passWord = "Simple.V.P.N_U03";
        private static string _preSharedKey = "seed4me";

        private static RasDialer _dialer;
        private static RasHandle _handle;
        public static void Connect()
        {
            _dialer = new RasDialer();
            using (RasPhoneBook PhoneBook = new RasPhoneBook())
            {
                PhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));
                RasEntry Entry;

                if (PhoneBook.Entries.Contains(_adapterName))
                {
                    PhoneBook.Entries.Remove(_adapterName);
                }
                if (_adapterName.Equals("PPTP"))
                {
                    Entry = RasEntry.CreateVpnEntry(_adapterName, ServerIp, RasVpnStrategy.PptpOnly, RasDevice.GetDeviceByName("(PPTP)", RasDeviceType.Vpn));
                }
                else
                {
                    Entry = RasEntry.CreateVpnEntry(_adapterName, ServerIp, RasVpnStrategy.L2tpOnly, RasDevice.GetDeviceByName("(L2TP)", RasDeviceType.Vpn));
                }

                PhoneBook.Entries.Add(Entry);
                Entry.Options.PreviewDomain = false;
                Entry.Options.ShowDialingProgress = false;
                Entry.Options.PromoteAlternates = false;
                Entry.Options.DoNotNegotiateMultilink = false;

                if (VpnProtocol.Equals("L2TP"))
                {
                    Entry.Options.UsePreSharedKey = true;
                    Entry.UpdateCredentials(RasPreSharedKey.Client, _preSharedKey);
                    Entry.Update();
                }

                _dialer.EntryName = _adapterName;
                _dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
                _dialer.Credentials = new NetworkCredential(_userName, _passWord);
            }
            _handle = _dialer.DialAsync();
        }

        public static void Disconnect()
        {
            if (_dialer.IsBusy)
            {
                _dialer.DialAsyncCancel();
            }
            else
            {
                if (_handle != null)
                {
                    RasConnection Connection = RasConnection.GetActiveConnectionByHandle(_handle);
                    if (Connection != null)
                    {
                        Connection.HangUp();
                    }
                }
            }

            using (RasPhoneBook PhoneBook = new RasPhoneBook())
            {
                PhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));

                if (PhoneBook.Entries.Contains(_adapterName))
                {
                    PhoneBook.Entries.Remove(_adapterName);
                }
            }
        }
    }
}
