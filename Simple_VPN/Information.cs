using System;
using Simple_VPN.Classes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Simple_VPN
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            SubLblDyn.Text = $"{Status.TotalSubDays()} Days Left";
        }

        private void TelegramPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://telegram.me/AmirHossein_Rnj_01");
        }

        private void InstagramPicBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/ahossein_rnj");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Information_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
