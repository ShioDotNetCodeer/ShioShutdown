namespace ShioShutdown
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tab = new TabControl();
            tabPage1 = new TabPage();
            nud = new NumericUpDown();
            panel1 = new Panel();
            rb_sec = new RadioButton();
            rb_min = new RadioButton();
            rb_hour = new RadioButton();
            tabPage2 = new TabPage();
            dtp = new DateTimePicker();
            btn_exec = new Button();
            bar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            tab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabPage1);
            tab.Controls.Add(tabPage2);
            tab.Dock = DockStyle.Top;
            tab.Font = new Font("Microsoft YaHei UI", 14F);
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(5, 4, 5, 4);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(280, 140);
            tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nud);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(5, 4, 5, 4);
            tabPage1.Size = new Size(272, 102);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "倒计时";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nud
            // 
            nud.Font = new Font("Microsoft YaHei UI", 14F);
            nud.Location = new Point(5, 64);
            nud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud.Name = "nud";
            nud.Size = new Size(262, 31);
            nud.TabIndex = 3;
            nud.TextAlign = HorizontalAlignment.Center;
            nud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Controls.Add(rb_sec);
            panel1.Controls.Add(rb_min);
            panel1.Controls.Add(rb_hour);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 4);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 53);
            panel1.TabIndex = 0;
            // 
            // rb_sec
            // 
            rb_sec.AutoSize = true;
            rb_sec.Location = new Point(163, 12);
            rb_sec.Margin = new Padding(5, 4, 5, 4);
            rb_sec.Name = "rb_sec";
            rb_sec.Size = new Size(49, 29);
            rb_sec.TabIndex = 2;
            rb_sec.Text = "秒";
            rb_sec.UseVisualStyleBackColor = true;
            rb_sec.CheckedChanged += rb_sec_CheckedChanged;
            // 
            // rb_min
            // 
            rb_min.AutoSize = true;
            rb_min.Location = new Point(94, 12);
            rb_min.Margin = new Padding(5, 4, 5, 4);
            rb_min.Name = "rb_min";
            rb_min.Size = new Size(49, 29);
            rb_min.TabIndex = 1;
            rb_min.Text = "分";
            rb_min.UseVisualStyleBackColor = true;
            rb_min.CheckedChanged += rb_min_CheckedChanged;
            // 
            // rb_hour
            // 
            rb_hour.AutoSize = true;
            rb_hour.Checked = true;
            rb_hour.Location = new Point(25, 12);
            rb_hour.Margin = new Padding(5, 4, 5, 4);
            rb_hour.Name = "rb_hour";
            rb_hour.Size = new Size(49, 29);
            rb_hour.TabIndex = 0;
            rb_hour.TabStop = true;
            rb_hour.Text = "时";
            rb_hour.UseVisualStyleBackColor = true;
            rb_hour.CheckedChanged += rb_hour_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dtp);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(5, 4, 5, 4);
            tabPage2.Size = new Size(272, 102);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "指定时间";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            dtp.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Location = new Point(8, 35);
            dtp.Name = "dtp";
            dtp.Size = new Size(261, 31);
            dtp.TabIndex = 0;
            // 
            // btn_exec
            // 
            btn_exec.AutoSize = true;
            btn_exec.Location = new Point(4, 143);
            btn_exec.Name = "btn_exec";
            btn_exec.Size = new Size(272, 35);
            btn_exec.TabIndex = 4;
            btn_exec.Text = "开始执行";
            btn_exec.UseVisualStyleBackColor = true;
            btn_exec.Click += btn_exec_Click;
            // 
            // bar
            // 
            bar.Dock = DockStyle.Bottom;
            bar.Location = new Point(0, 180);
            bar.MarqueeAnimationSpeed = 500;
            bar.Name = "bar";
            bar.Size = new Size(280, 23);
            bar.Step = 1;
            bar.TabIndex = 2;
            bar.Value = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 203);
            Controls.Add(bar);
            Controls.Add(btn_exec);
            Controls.Add(tab);
            Font = new Font("Microsoft YaHei UI", 14F);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "自动关机";
            Load += Form1_Load;
            tab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private RadioButton rb_sec;
        private RadioButton rb_min;
        private RadioButton rb_hour;
        private NumericUpDown nud;
        private Button btn_exec;
        private ProgressBar bar;
        private DateTimePicker dtp;
        private System.Windows.Forms.Timer timer;
    }
}
