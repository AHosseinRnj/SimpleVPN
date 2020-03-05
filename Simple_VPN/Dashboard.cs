using System;
using System.Drawing;
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
            Connection_Authentication();
            Administrator_Authentication();        
            DisconnectBtn_Enabled_False();
            CountriesCmBox.SelectedIndex = 0;
        }

        private string _serverip = ""; // Leave it Empty
        private string _vpnname = "SimpleVPN"; // Leave it or Set whatever You Want
        private string _username = ""; // Your Username here
        private string _password = ""; // Your Password here
        PPTPProtocol PPTP_Class;

        private void CountriesCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountriesCmBox.SelectedItem.Equals("Select"))
            {
                CountriesFlgPicBox.Image = Simple_VPN.Properties.Resources.question__1_;
            }
            else if (CountriesCmBox.SelectedItem.Equals("Netherlands"))
            {
                _serverip = ""; // Set Your IP Here
                CreateAdapterMethod();
                CountriesFlgPicBox.Image = Simple_VPN.Properties.Resources.NetherlandsFlg;
            }
            else if (CountriesCmBox.SelectedItem.Equals("Germany"))
            {
                _serverip = ""; // Set Your IP Here
                CreateAdapterMethod();
                CountriesFlgPicBox.Image = Simple_VPN.Properties.Resources.GermanyFlg;
            }
            else if (CountriesCmBox.SelectedItem.Equals("Argentina"))
            {
                _serverip = ""; // Set Your IP Here
                CreateAdapterMethod();
                CountriesFlgPicBox.Image = Simple_VPN.Properties.Resources.ArgentinaFlg;
            }
            else if (CountriesCmBox.SelectedItem.Equals("United States"))
            {
                _serverip = ""; // Set Your IP Here
                CreateAdapterMethod();
                CountriesFlgPicBox.Image = Simple_VPN.Properties.Resources.UsaFlg;
            }
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (CountriesCmBox.SelectedItem.Equals("Select"))
            {
                MessageBox.Show("Please Select a Location", "Error at 0.65", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    PPTP_Class.Connect();
                }
                catch (Exception ex)
                {
                    //
                }
                finally
                {
                    ConnectBtn_Enabled_False();
                    DisconnectBtn_Enabled_True();
                    CountriesCmBox_Enabled_False();
                    statusPicbox.Image = Simple_VPN.Properties.Resources.Connectpic;
                }
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PPTP_Class.Disconnect();
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                ConnectBtn_Enabled_True();
                DisconnectBtn_Enabled_False();
                CountriesCmBox_Enabled_True();
                statusPicbox.Image = Simple_VPN.Properties.Resources.Disconnectpic;
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            Information InfoDialog = new Information();
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void DisconnectBtn_Enabled_False()
        {
            DisconnectBtn.Enabled = false;
            DisconnectBtn.ForeColor = Color.FromArgb(93, 97, 105);
            DisconnectBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void DisconnectBtn_Enabled_True()
        {
            DisconnectBtn.Enabled = true;
            DisconnectBtn.ForeColor = Color.FromArgb(244, 170, 80);
            DisconnectBtn.BackColor = Color.Transparent;
        }

        public void ConnectBtn_Enabled_False()
        {
            ConnectBtn.Enabled = false;
            ConnectBtn.ForeColor = Color.FromArgb(93, 97, 105);
            ConnectBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void ConnectBtn_Enabled_True()
        {
            ConnectBtn.Enabled = true;
            ConnectBtn.ForeColor = Color.FromArgb(244, 170, 80);
            ConnectBtn.BackColor = Color.Transparent;
        }

        public void ExitBtn_Enabled_False()
        {
            ExitBtn.Enabled = false;
            ExitBtn.ForeColor = Color.FromArgb(93, 97, 105);
            ExitBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void ExitBtn_Enabled_True()
        {
            ExitBtn.Enabled = true;
            ExitBtn.ForeColor = Color.FromArgb(244, 170, 80);
            ExitBtn.BackColor = Color.Transparent;
        }

        public void CountriesCmBox_Enabled_False()
        {
            CountriesCmBox.Enabled = false;
            CountriesCmBox.ForeColor = Color.FromArgb(93, 97, 105);
            CountriesCmBox.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void CountriesCmBox_Enabled_True()
        {
            CountriesCmBox.Enabled = true;
            CountriesCmBox.ForeColor = Color.FromArgb(244, 170, 80);
            CountriesCmBox.BackColor = Color.FromArgb(22, 27, 33);
        }

        public void ExitMethod()
        {
            if (ConnectBtn.Enabled == false)
            {
                MessageBox.Show("Please Disconnect First", "Error at 0.219", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Application.Exit();
                try
                {
                    PPTP_Class.RemoveAdaptor();
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        public void CreateAdapterMethod()
        {
            PPTP_Class = new PPTPProtocol(_vpnname, _serverip, _username, _password);
            PPTP_Class.RemoveAdaptor();
            PPTP_Class.CreateConnection();
        }

        public void Connection_Authentication()
        {
            while (true)
            {
                bool Auth = ConnectionChecker.InternetConnectionChecker();
                if (Auth == false)
                {
                    DialogResult Dr = MessageBox.Show("You are not Connected to the internet", "No Connection",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (Dr == DialogResult.Retry)
                    {
                        if (Auth == true)
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

        public void Administrator_Authentication()
        {
            bool Auth = AdministratorChecker.IsAdministrator();
            if (Auth == false)
            {
                DialogResult Dr = MessageBox.Show("Please Re-start and Run it as Administrator", "Permission Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Dr == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
