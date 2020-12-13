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

        DashboardDesignClass MainUI;
        ServerSelector countryLocation;
        Information InfoDialog = new Information();
        VPN VPN = new VPN();

        private void Form1_Load(object sender, EventArgs e)
        {
            Administrator_Authentication();
            Connection_Authentication();
            countryLocation = new ServerSelector();
            MainUI = new DashboardDesignClass();
            CountriesCmBox.SelectedIndex = 0;
            MainUI.DisconnectBtn_Enabled_False();
        }

        /* 
         * The Below Username & Password Valid Till : Monday, 19 April 2021
         *
         *       !!!  Don't Modify ServerIP & selectedProtocol !!!
         * adapterName : You can choose whatever you like .
         * 
         * userName : Your username & passWord : Your password .
         * preSharedKey : Your PreSharedKey if needed .
         * 
         * You can set your serverAddresses in Classes/ServerSelector.cs .
         * 
         */

        private string serverIP;
        private string adapterName = "SimpleVPN";
        private string userName = "na.tasha.m.end.e.ztm.p@gmail.com";
        private string passWord = "Simple.V.P.N_U02";
        private string preSharedKey = "seed4me";
        private string selectedProtocol;

        private void CountriesCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serverIP = countryLocation.ServerIp(CountriesCmBox.SelectedItem.ToString());
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (CountriesCmBox.SelectedItem.Equals("Select"))
            {
                MessageBox.Show("Please Select a Location", "Error at 0x59", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (PPTP_rBtn.Checked == false && L2TP_rBtn.Checked == false)
                {
                    MessageBox.Show("Please Select a Protocol", "Error at 0x65", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    VPN.setParameters(serverIP, adapterName, userName, passWord, selectedProtocol, preSharedKey);
                    try
                    {
                        VPN.Connect();
                    }
                    finally
                    {
                        MainUI.ConnectBtn_Enabled_False();
                        MainUI.DisconnectBtn_Enabled_True();
                        MainUI.CountriesCmBox_Enabled_False();
                        statusPicbox.Image = Properties.Resources.Connectpic;
                        GC.Collect();
                    }
                }
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                VPN.Disconnect();
            }
            finally
            {
                MainUI.ConnectBtn_Enabled_True();
                MainUI.DisconnectBtn_Enabled_False();
                MainUI.CountriesCmBox_Enabled_True();
                statusPicbox.Image = Properties.Resources.Disconnectpic;
                GC.Collect();
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            InfoDialog.ShowDialog();
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
            selectedProtocol = "PPTP";
        }

        private void L2TP_rBtn_MouseClick(object sender, MouseEventArgs e)
        {
            selectedProtocol = "L2TP";
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

        public void ExitMethod()
        {
            if (ConnectBtn.Enabled == false)
            {
                MessageBox.Show("Please Disconnect First", "Error at 0x168", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                VPN.Dispose();
                VPN = null;
                MainUI = null;
                countryLocation = null;
                InfoDialog = null;
                GC.Collect();
                Application.Exit();
            }
        }

        private void Connection_Authentication()
        {
            while (true)
            {
                if (Status.IsConnected() == false)
                {
                    DialogResult Dr = MessageBox.Show("You are not Connected to the internet", "No Connection",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (Dr == DialogResult.Retry)
                    {
                        if (Status.IsConnected() == true)
                            break;
                        else
                            continue;
                    }
                    else
                    {
                        Application.Exit();
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void Administrator_Authentication()
        {
            if (Status.IsAdministrator() == false)
            {
                DialogResult Dr = MessageBox.Show("Please Re-start as an Administrator", "Permission Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Dr == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}