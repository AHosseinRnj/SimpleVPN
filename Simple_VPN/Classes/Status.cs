using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_VPN.Classes
{
    class Status
    {
        private static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static bool IsConnected()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<int> GetPingAsync(string ip)
        {
            long totalTime = 0;
            int echo = 4;
            int timeout = 999;
            Ping pingSender = new Ping();

            for (int i = 0; i < echo; i++)
            {
                PingReply reply = await Task.Run(() => pingSender.Send(ip, timeout));

                if (reply.Status == IPStatus.Success)
                {
                    totalTime += reply.RoundtripTime;
                }
            }

            return (int)(totalTime / echo);
        }

        static DateTime endSub = new DateTime(2022, 10, 10);
        public static int TotalSubDays()
        {
            TimeSpan subResult = endSub.Subtract(DateTime.Today);
            if (subResult.Days < 0)
                return 0;
            else
                return (int)subResult.TotalDays;
        }

        public static void ConnectionAuth()
        {
            while (!IsConnected())
            {
                var DialogResult = MessageBox.Show("You are not Connected to the internet", "No Connection",
                                                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (DialogResult == DialogResult.Cancel)
                {
                    break;
                }
            }

            if (!IsConnected())
            {
                Application.Exit();
            }
        }

        public static void AdministratorAuth()
        {
            if (!IsAdministrator())
            {
                var DialogResult = MessageBox.Show("Please Re-start as an Administrator", "Permission Denied",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (DialogResult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
