namespace Simple_VPN
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.SeprLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.LatestLbl = new System.Windows.Forms.Label();
            this.LatestDynLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TelegramPicBox = new System.Windows.Forms.PictureBox();
            this.InstagramPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TelegramPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstagramPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SeprLbl
            // 
            this.SeprLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeprLbl.Location = new System.Drawing.Point(2, 34);
            this.SeprLbl.Name = "SeprLbl";
            this.SeprLbl.Size = new System.Drawing.Size(538, 1);
            this.SeprLbl.TabIndex = 3;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.ExitBtn.Location = new System.Drawing.Point(515, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(25, 26);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.NameLbl.Location = new System.Drawing.Point(1, 8);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(125, 18);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Change Logs :";
            // 
            // LatestLbl
            // 
            this.LatestLbl.AutoSize = true;
            this.LatestLbl.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.LatestLbl.Location = new System.Drawing.Point(12, 45);
            this.LatestLbl.Name = "LatestLbl";
            this.LatestLbl.Size = new System.Drawing.Size(47, 18);
            this.LatestLbl.TabIndex = 6;
            this.LatestLbl.Text = "1.1.0 :";
            // 
            // LatestDynLbl
            // 
            this.LatestDynLbl.AutoSize = true;
            this.LatestDynLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatestDynLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.LatestDynLbl.Location = new System.Drawing.Point(25, 71);
            this.LatestDynLbl.Name = "LatestDynLbl";
            this.LatestDynLbl.Size = new System.Drawing.Size(410, 112);
            this.LatestDynLbl.TabIndex = 7;
            this.LatestDynLbl.Text = "- Minor bug Fixed\r\n- More Optimization\r\n- Added New Serveral Several Location ( U" +
    "SA , Argentina , Germany )\r\n- New Feature ( Hide To System Tray )\r\n- Removed Log" +
    "Box From Main Form\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(170)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ways To Contact Me :";
            // 
            // TelegramPicBox
            // 
            this.TelegramPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TelegramPicBox.Image = global::Simple_VPN.Properties.Resources.Telegram_Logo;
            this.TelegramPicBox.Location = new System.Drawing.Point(184, 199);
            this.TelegramPicBox.Name = "TelegramPicBox";
            this.TelegramPicBox.Size = new System.Drawing.Size(86, 85);
            this.TelegramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TelegramPicBox.TabIndex = 9;
            this.TelegramPicBox.TabStop = false;
            this.TelegramPicBox.Click += new System.EventHandler(this.TelegramPicBox_Click);
            // 
            // InstagramPicBox
            // 
            this.InstagramPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InstagramPicBox.Image = global::Simple_VPN.Properties.Resources.Instagram_Logo;
            this.InstagramPicBox.Location = new System.Drawing.Point(276, 194);
            this.InstagramPicBox.Name = "InstagramPicBox";
            this.InstagramPicBox.Size = new System.Drawing.Size(94, 93);
            this.InstagramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InstagramPicBox.TabIndex = 10;
            this.InstagramPicBox.TabStop = false;
            this.InstagramPicBox.Click += new System.EventHandler(this.InstagramPicBox_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(543, 315);
            this.ControlBox = false;
            this.Controls.Add(this.InstagramPicBox);
            this.Controls.Add(this.TelegramPicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LatestDynLbl);
            this.Controls.Add(this.LatestLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SeprLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Information_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Information_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.TelegramPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstagramPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeprLbl;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label LatestLbl;
        private System.Windows.Forms.Label LatestDynLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox TelegramPicBox;
        private System.Windows.Forms.PictureBox InstagramPicBox;
    }
}