using System.Drawing;
using System.Windows.Forms;

namespace Simple_VPN.Classes
{
    class DashboardDesignClass
    {
        Button DisconnectBtn = Application.OpenForms["Dashboard"].Controls["DisconnectBtn"] as Button;
        Button ConnectBtn = Application.OpenForms["Dashboard"].Controls["ConnectBtn"] as Button;
        Button ExitBtn = Application.OpenForms["Dashboard"].Controls["ExitBtn"] as Button;
        ComboBox CountriesCmBox = Application.OpenForms["Dashboard"].Controls["CountriesCmBox"] as ComboBox;
        
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
    }
}
