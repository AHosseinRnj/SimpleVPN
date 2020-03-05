using System.Security.Principal;

namespace Simple_VPN.Classes
{
    class AdministratorChecker
    {
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
             .IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
