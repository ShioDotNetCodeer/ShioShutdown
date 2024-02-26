using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ShioShutdown
{
    public partial class Form1 : Form
    {
        #region ˽�б���
        private bool Exec = false;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp.Value = DateTime.Now.AddHours(1);
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            ChangeMax();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (bar.Value == bar.Maximum)
            {
                OnecShutdown();
                // ProgressBar ���ʱִ�еĲ���
                timer.Stop();
            }
            bar.PerformStep();
        }

        private void rb_hour_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMax();
        }

        private void rb_min_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMax();
        }

        private void rb_sec_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMax();
        }

        /// <summary>
        /// ��ʼִ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_exec_Click(object sender, EventArgs e)
        {
            if (Exec == false)
            {
                btn_exec.Text = "��ִֹ��";
                Exec = true;
            }
            else
            {
                timer.Stop();
                Exec = false;
                btn_exec.Text = "��ʼִ��";
            }
            if (tab.SelectedIndex == 0)
            {
                CountDown();
            }
            else
            {

            }
        }

        #region ˽�з���
        private void ChangeMax()
        {
            if (rb_hour.Checked)
            {
                nud.Maximum = 23;
                bar.Maximum = 23;
            }
            else
            {
                nud.Maximum = 59;
                bar.Maximum = 59;
            }
        }
        /// <summary>
        /// ����ʱ
        /// </summary>
        private void CountDown()
        {
            decimal sec = 0;
            if (rb_hour.Checked)
                sec = 60 * 60 * nud.Value;
            else if (rb_min.Checked)
                sec = 60 * nud.Value;
            else
                sec = nud.Value;
            bar.Value = 1;
            bar.Maximum = (int)sec;
            timer.Start();
        }
        private void Down()
        {
            var sec = (int)(dtp.Value - DateTime.Now).TotalSeconds;
            bar.Value = 1;
            bar.Maximum = (int)sec;
            timer.Start();
        }



        private void OnecShutdown()
        {
            ExitWindowsEx(EWX_SHUTDOWN, 0);
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.Verb = "runas";
            //startInfo.FileName = "shutdown.exe";
            //startInfo.Arguments = "-s -t 2" ;
            //Process.Start(startInfo);
        }
        /// <summary>
        /// �ػ�
        /// </summary>
        private const uint EWX_SHUTDOWN = 0x00000001;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ExitWindowsEx(uint uFlags, uint dwReason);
        #endregion


    }
}
