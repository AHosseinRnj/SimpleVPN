using System.Windows.Forms;

namespace Simple_VPN.Classes
{
    class ServerSelector
    {
        PictureBox CountriesFlgPicBox = Application.OpenForms["Dashboard"].Controls["CountriesFlgPicBox"] as PictureBox;
        private string IP;
        public string ServerIp(string locationName)
        {
            switch (locationName)
            {
                case "France":
                    IP = "193.70.64.90";
                    CountriesFlgPicBox.Image = Properties.Resources.FranceFlg;
                    break;
                case "Canada":
                    IP = "79.141.166.2";
                    CountriesFlgPicBox.Image = Properties.Resources.CanadaFlg;
                    break;
                case "Germany":
                    IP = "217.20.114.208";
                    CountriesFlgPicBox.Image = Properties.Resources.GermanyFlg;
                    break;
                case "Argentina":
                    IP = "190.103.177.28";
                    CountriesFlgPicBox.Image = Properties.Resources.ArgentinaFlg;
                    break;
                case "Netherlands":
                    IP = "185.142.239.83";
                    CountriesFlgPicBox.Image = Properties.Resources.NetherlandsFlg;
                    break;
                case "United States":
                    IP = "147.135.116.81";
                    CountriesFlgPicBox.Image = Properties.Resources.UsaFlg;
                    break;
                case "Russian Federation":
                    IP = "45.137.190.23";
                    CountriesFlgPicBox.Image = Properties.Resources.RussiaFlg;
                    break;
                default:
                    IP = string.Empty;
                    CountriesFlgPicBox.Image = Properties.Resources.question__1_;
                    break;
            }
            return IP;
        }
    }
}
