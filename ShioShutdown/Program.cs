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
            // �жϵ�ǰ�û��Ƿ���й���ԱȨ��
            if (!IsAdministrator())
            {
                MessageBox.Show("���ѹ���Ա�������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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