using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Simple_VPN.Classes;

namespace Simple_VPN
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Status.AdministratorAuth();
            Status.ConnectionAuth();

            Server.Initialize();

            CountriesCmBox.SelectedIndex = 0;
            DisconnectBtnEnabledFalse();
        }

        private async void CountriesCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ServerLocation = CountriesCmBox.SelectedItem.ToString();
            Vpn.ServerIp = Server.GetIp(ServerLocation);
            ImageLoader(ServerLocation);

            int pingResult = await Status.GetPingAsync(Vpn.ServerIp); ;
            PingLbl.Text = $"{pingResult} ms";
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (CountriesCmBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select a Location", "Error at 0x40", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!PPTP_rBtn.Checked && !L2TP_rBtn.Checked)
                {
                    MessageBox.Show("Please Select a Protocol", "Error at 0x46", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Vpn.Connect();
                    }
                    finally
                    {
                        ConnectBtnEnabledFalse();
                        DisconnectBtnEnabledTrue();
                        CountriesCmBoxEnabledFalse();
                        statusPicbox.Image = Properties.Resources.Connectpic;
                    }
                }
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Vpn.Disconnect();
            }
            finally
            {
                ConnectBtnEnabledTrue();
                DisconnectBtnEnabledFalse();
                CountriesCmBoxEnabledTrue();
                statusPicbox.Image = Properties.Resources.Disconnectpic;
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            using (Information InfoDialog = new Information())
            {
                InfoDialog.ShowDialog();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            ExitMethod();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            Hide();
            NotifyIcon.Visible = true;
            NotifyIcon.ContextMenuStrip = CMenu;
            NotifyIcon.ShowBalloonTip(1000);
        }

        private void openApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitMethod();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void PPTP_rBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Vpn.VpnProtocol = "PPTP";
        }

        private void L2TP_rBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Vpn.VpnProtocol = "L2TP";
        }

        public void ExitMethod()
        {
            if (!ConnectBtn.Enabled)
            {
                MessageBox.Show("Please Disconnect First", "Error at 0x134", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Application.Exit();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}