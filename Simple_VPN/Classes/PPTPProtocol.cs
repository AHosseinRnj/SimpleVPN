using System;
using System.Net;
using DotRas;

namespace Simple_VPN.Classes
{
    class PPTPProtocol
    {
        string _VpnName;
        string _ServerIP;
        string _UserName;
        string _PassWord;

        public PPTPProtocol(string vpnname, string serverip, string username, string password)
        {
            _VpnName = vpnname;
            _ServerIP = serverip;
            _UserName = username;
            _PassWord = password;
        }

        RasPhoneBook RPB = new RasPhoneBook();
        RasDialer RD = new RasDialer();
        private RasHandle Handle = null;
        RasEntry Entry;
        public void CreateConnection()
        {
            try
            {
                RPB.Open();
                Entry = RasEntry.CreateVpnEntry(_VpnName, _ServerIP, RasVpnStrategy.PptpOnly,
                    RasDevice.GetDeviceByName("(PPTP)", RasDeviceType.Vpn, false));
                RPB.Entries.Add(Entry);
            }
            catch (Exception ex)
            {

            }
        }

        public void Connect()
        {
            try
            {
                RD.EntryName = _VpnName;
                RD.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
            }
            catch (Exception ex)
            {

            }

            try
            {
                RD.Credentials = new NetworkCredential(_UserName, _PassWord);
                Handle = RD.DialAsync();
            }
            catch (Exception ex)
            {

            }
        }

        public void Disconnect()
        {
            if (RD.IsBusy)
            {
                RD.DialAsyncCancel();
            }
            else
            {
                RasConnection Connection = RasConnection.GetActiveConnectionByHandle(Handle);
                if (Connection != null)
                {
                    Connection.HangUp();
                    RemoveAdaptor();
                }
            }
        }

        public void RemoveAdaptor()
        {
            try
            {
                RPB.Entries.Remove(Entry.Name);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
