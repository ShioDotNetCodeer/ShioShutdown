using System.Diagnostics;
using System.Security.Principal;

namespace ShioShutdown
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 判断当前用户是否具有管理员权限
            if (!IsAdministrator())
            {
                MessageBox.Show("请已管理员身份运行", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}