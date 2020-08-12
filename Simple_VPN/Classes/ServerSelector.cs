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
                    IP = "fr.s4m.xyz";
                    CountriesFlgPicBox.Image = Properties.Resources.FranceFlg;
                    break;
                case "Canada":
                    IP = "ca.s4m.xyz";
                    CountriesFlgPicBox.Image = Properties.Resources.CanadaFlg;
                    break;
                case "Germany":
                    IP = "de.s4m.xyz";
                    CountriesFlgPicBox.Image = Properties.Resources.GermanyFlg;
                    break;
                case "Argentina":
                    IP = "ar.s4m.xyz";
                    CountriesFlgPicBox.Image = Properties.Resources.ArgentinaFlg;
                    break;
                case "Netherlands":
                    IP = "nl.s4m.xyz";
                    CountriesFlgPicBox.Image = Properties.Resources.NetherlandsFlg;
                    break;
                case "United States":
                    IP = "us.s4m.xyz";
                    CountriesFlgPicBox.Image = Properties.Resources.UsaFlg;
                    break;
                case "Russian Federation":
                    IP = "ru.s4m.xyz";
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
