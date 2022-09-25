using System.Drawing;

namespace Simple_VPN
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.SeprLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.CountriesCmBox = new System.Windows.Forms.ComboBox();
            this.CountriesFlgPicBox = new System.Windows.Forms.PictureBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.statusPicbox = new System.Windows.Forms.PictureBox();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.openApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InfoBtn = new System.Windows.Forms.Button();
            this.PPTP_rBtn = new System.Windows.Forms.RadioButton();
            this.ProtocolGrpBox = new System.Windows.Forms.GroupBox();
            this.L2TP_rBtn = new System.Windows.Forms.RadioButton();
            this.PingLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesFlgPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicbox)).BeginInit();
            this.CMenu.SuspendLayout();
            this.ProtocolGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.ExitBtn.Location = new System.Drawing.Point(327, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 26);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.MiniBtn.Location = new System.Drawing.Point(299, 3);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(25, 26);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.Text = "_";
            this.MiniBtn.UseVisualStyleBackColor = true;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // SeprLbl
            // 
            this.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeprLbl.Location = new System.Drawing.Point(3, 35);
            this.SeprLbl.Name = "SeprLbl";
            this.SeprLbl.Size = new System.Drawing.Size(349, 1);
            this.SeprLbl.TabIndex = 2;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.NameLbl.Location = new System.Drawing.Point(-1, 7);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(145, 22);
            this.NameLbl.TabIndex = 3;
            this.NameLbl.Text = "SimpleVPN 1.3.5";
            // 
            // CountriesCmBox
            // 
            this.CountriesCmBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.CountriesCmBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountriesCmBox.DropDownHeight = 95;
            this.CountriesCmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountriesCmBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountriesCmBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountriesCmBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.CountriesCmBox.FormattingEnabled = true;
            this.CountriesCmBox.IntegralHeight = false;
            this.CountriesCmBox.ItemHeight = 23;
            this.CountriesCmBox.Items.AddRange(new object[] {
            "France",
            "Canada",
            "Germany",
            "Argentina",
            "Netherlands",
            "United States",
            "Russian Federation"});
            this.CountriesCmBox.Location = new System.Drawing.Point(12, 285);
            this.CountriesCmBox.Name = "CountriesCmBox";
            this.CountriesCmBox.Size = new System.Drawing.Size(222, 31);
            this.CountriesCmBox.TabIndex = 4;
            this.CountriesCmBox.SelectedIndexChanged += new System.EventHandler(this.CountriesCmBox_SelectedIndexChanged);
            // 
            // CountriesFlgPicBox
            // 
            this.CountriesFlgPicBox.Location = new System.Drawing.Point(240, 285);
            this.CountriesFlgPicBox.Name = "CountriesFlgPicBox";
            this.CountriesFlgPicBox.Size = new System.Drawing.Size(34, 31);
            this.CountriesFlgPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CountriesFlgPicBox.TabIndex = 5;
            this.CountriesFlgPicBox.TabStop = false;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.ConnectBtn.Location = new System.Drawing.Point(180, 324);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(165, 43);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.DisconnectBtn.Location = new System.Drawing.Point(12, 324);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(164, 43);
            this.DisconnectBtn.TabIndex = 7;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // statusPicbox
            // 
            this.statusPicbox.Image = global::Simple_VPN.Properties.Resources.Disconnectpic;
            this.statusPicbox.Location = new System.Drawing.Point(89, 46);
            this.statusPicbox.Name = "statusPicbox";
            this.statusPicbox.Size = new System.Drawing.Size(181, 181);
            this.statusPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusPicbox.TabIndex = 8;
            this.statusPicbox.TabStop = false;
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIcon.BalloonTipText = "Running in background";
            this.NotifyIcon.BalloonTipTitle = "SimpleVPN";
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "SimpleVPN";
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // openApplicationToolStripMenuItem
            // 
            this.openApplicationToolStripMenuItem.Name = "openApplicationToolStripMenuItem";
            this.openApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openApplicationToolStripMenuItem.Text = "Open Application";
            this.openApplicationToolStripMenuItem.Click += new System.EventHandler(this.openApplicationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CMenu
            // 
            this.CMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openApplicationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CMenu.Name = "CMenu";
            this.CMenu.Size = new System.Drawing.Size(168, 48);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.InfoBtn.Location = new System.Drawing.Point(271, 3);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(25, 26);
            this.InfoBtn.TabIndex = 12;
            this.InfoBtn.Text = "?";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // PPTP_rBtn
            // 
            this.PPTP_rBtn.AutoSize = true;
            this.PPTP_rBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PPTP_rBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPTP_rBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.PPTP_rBtn.Location = new System.Drawing.Point(77, 13);
            this.PPTP_rBtn.Name = "PPTP_rBtn";
            this.PPTP_rBtn.Size = new System.Drawing.Size(71, 27);
            this.PPTP_rBtn.TabIndex = 13;
            this.PPTP_rBtn.Text = "PPTP";
            this.PPTP_rBtn.UseVisualStyleBackColor = true;
            this.PPTP_rBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PPTP_rBtn_MouseClick);
            // 
            // ProtocolGrpBox
            // 
            this.ProtocolGrpBox.Controls.Add(this.L2TP_rBtn);
            this.ProtocolGrpBox.Controls.Add(this.PPTP_rBtn);
            this.ProtocolGrpBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProtocolGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.ProtocolGrpBox.Location = new System.Drawing.Point(12, 233);
            this.ProtocolGrpBox.Name = "ProtocolGrpBox";
            this.ProtocolGrpBox.Size = new System.Drawing.Size(333, 46);
            this.ProtocolGrpBox.TabIndex = 14;
            this.ProtocolGrpBox.TabStop = false;
            this.ProtocolGrpBox.Text = "Protocol";
            // 
            // L2TP_rBtn
            // 
            this.L2TP_rBtn.AutoSize = true;
            this.L2TP_rBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.L2TP_rBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2TP_rBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.L2TP_rBtn.Location = new System.Drawing.Point(190, 13);
            this.L2TP_rBtn.Name = "L2TP_rBtn";
            this.L2TP_rBtn.Size = new System.Drawing.Size(68, 27);
            this.L2TP_rBtn.TabIndex = 14;
            this.L2TP_rBtn.Text = "L2TP";
            this.L2TP_rBtn.UseVisualStyleBackColor = true;
            this.L2TP_rBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.L2TP_rBtn_MouseClick);
            // 
            // PingLbl
            // 
            this.PingLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.PingLbl.Location = new System.Drawing.Point(280, 285);
            this.PingLbl.Name = "PingLbl";
            this.PingLbl.Size = new System.Drawing.Size(65, 31);
            this.PingLbl.TabIndex = 15;
            this.PingLbl.Text = "0 ms";
            this.PingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(355, 375);
            this.ControlBox = false;
            this.Controls.Add(this.PingLbl);
            this.Controls.Add(this.ProtocolGrpBox);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.statusPicbox);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.CountriesFlgPicBox);
            this.Controls.Add(this.CountriesCmBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SeprLbl);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.CountriesFlgPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPicbox)).EndInit();
            this.CMenu.ResumeLayout(false);
            this.ProtocolGrpBox.ResumeLayout(false);
            this.ProtocolGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Label SeprLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ComboBox CountriesCmBox;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.PictureBox statusPicbox;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem openApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMenu;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.RadioButton PPTP_rBtn;
        private System.Windows.Forms.GroupBox ProtocolGrpBox;
        private System.Windows.Forms.RadioButton L2TP_rBtn;
        public System.Windows.Forms.PictureBox CountriesFlgPicBox;
        private System.Windows.Forms.Label PingLbl;

        public void DisconnectBtnEnabledFalse()
        {
            DisconnectBtn.Enabled = false;
            DisconnectBtn.ForeColor = Color.FromArgb(93, 97, 105);
            DisconnectBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void DisconnectBtnEnabledTrue()
        {
            DisconnectBtn.Enabled = true;
            DisconnectBtn.ForeColor = Color.FromArgb(244, 170, 80);
            DisconnectBtn.BackColor = Color.Transparent;
        }

        public void ConnectBtnEnabledFalse()
        {
            ConnectBtn.Enabled = false;
            ConnectBtn.ForeColor = Color.FromArgb(93, 97, 105);
            ConnectBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void ConnectBtnEnabledTrue()
        {
            ConnectBtn.Enabled = true;
            ConnectBtn.ForeColor = Color.FromArgb(244, 170, 80);
            ConnectBtn.BackColor = Color.Transparent;
        }

        public void ExitBtnEnabledFalse()
        {
            ExitBtn.Enabled = false;
            ExitBtn.ForeColor = Color.FromArgb(93, 97, 105);
            ExitBtn.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void ExitBtnEnabledTrue()
        {
            ExitBtn.Enabled = true;
            ExitBtn.ForeColor = Color.FromArgb(244, 170, 80);
            ExitBtn.BackColor = Color.Transparent;
        }

        public void CountriesCmBoxEnabledFalse()
        {
            CountriesCmBox.Enabled = false;
            CountriesCmBox.ForeColor = Color.FromArgb(93, 97, 105);
            CountriesCmBox.BackColor = Color.FromArgb(93, 97, 105);
        }

        public void CountriesCmBoxEnabledTrue()
        {
            CountriesCmBox.Enabled = true;
            CountriesCmBox.ForeColor = Color.FromArgb(244, 170, 80);
            CountriesCmBox.BackColor = Color.FromArgb(22, 27, 33);
        }

        public void ImageLoader(string locationName)
        {
            switch (locationName)
            {
                case "France":
                    CountriesFlgPicBox.Image = Properties.Resources.FranceFlg;
                    break;
                case "Canada":
                    CountriesFlgPicBox.Image = Properties.Resources.CanadaFlg;
                    break;
                case "Germany":
                    CountriesFlgPicBox.Image = Properties.Resources.GermanyFlg;
                    break;
                case "Argentina":
                    CountriesFlgPicBox.Image = Properties.Resources.ArgentinaFlg;
                    break;
                case "Netherlands":
                    CountriesFlgPicBox.Image = Properties.Resources.NetherlandsFlg;
                    break;
                case "United States":
                    CountriesFlgPicBox.Image = Properties.Resources.UsaFlg;
                    break;
                case "Russian Federation":
                    CountriesFlgPicBox.Image = Properties.Resources.RussiaFlg;
                    break;
                default:
                    break;
            }
        }
    }
}