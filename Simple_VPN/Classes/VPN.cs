using System.Net;
using DotRas;

namespace Simple_VPN.Classes
{
    class VPN
    {
        private string serverIP;
        private string adapterName;
        private string userName;
        private string passWord;
        private string vpnProtocol;
        private string preSharedKey;
        public VPN(string serverIP, string adapterName, string userName, string passWord, string vpnProtocol, string preSharedKey)
        {
            this.serverIP = serverIP;
            this.adapterName = adapterName;
            this.userName = userName;
            this.passWord = passWord;
            this.vpnProtocol = vpnProtocol;
            this.preSharedKey = preSharedKey;
        }

        private RasDialer dialer;
        private RasHandle handle;
        public void Connect()
        {
            dialer = new RasDialer();
            using (RasPhoneBook PhoneBook = new RasPhoneBook())
            {
                PhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));
                RasEntry Entry;

                if (PhoneBook.Entries.Contains(adapterName))
                {
                    PhoneBook.Entries.Remove(adapterName);
                }
                if (vpnProtocol.Contains("PPTP"))
                {
                    Entry = RasEntry.CreateVpnEntry(adapterName, serverIP, RasVpnStrategy.PptpOnly, RasDevice.GetDeviceByName("(PPTP)", RasDeviceType.Vpn));
                }
                else
                {
                    Entry = RasEntry.CreateVpnEntry(adapterName, serverIP, RasVpnStrategy.L2tpOnly, RasDevice.GetDeviceByName("(L2TP)", RasDeviceType.Vpn));
                }

                PhoneBook.Entries.Add(Entry);
                Entry.Options.PreviewDomain = false;
                Entry.Options.ShowDialingProgress = false;
                Entry.Options.PromoteAlternates = false;
                Entry.Options.DoNotNegotiateMultilink = false;

                if (vpnProtocol.Equals("L2TP"))
                {
                    Entry.Options.UsePreSharedKey = true;
                    Entry.UpdateCredentials(RasPreSharedKey.Client, preSharedKey);
                    Entry.Update();
                }

                dialer.EntryName = adapterName;
                dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
                dialer.Credentials = new NetworkCredential(userName, passWord);
            }
            handle = dialer.DialAsync();
        }

        public void Disconnect()
        {
            if (dialer.IsBusy)
            {
                dialer.DialAsyncCancel();
            }
            else
            {
                if (handle != null)
                {
                    RasConnection Connection = RasConnection.GetActiveConnectionByHandle(handle);
                    if (Connection != null)
                    {
                        Connection.HangUp();
                    }
                }
            }

            using (RasPhoneBook PhoneBook = new RasPhoneBook())
            {
                PhoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));

                if (PhoneBook.Entries.Contains(adapterName))
                {
                    PhoneBook.Entries.Remove(adapterName);
                }
            }
        }

        public void Dispose()
        {
            adapterName = null;
            dialer = null;
            handle = null;
        }
    }
}
