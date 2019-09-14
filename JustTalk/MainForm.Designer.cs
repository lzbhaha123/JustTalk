namespace JustTalk
{
    partial class MainForm
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
            this.CreateHost = new System.Windows.Forms.Button();
            this.nickname_label = new System.Windows.Forms.Label();
            this.NickName = new System.Windows.Forms.TextBox();
            this.ipaddress_label = new System.Windows.Forms.Label();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.ConnectRemoteHost = new System.Windows.Forms.Button();
            this.version_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateHost
            // 
            this.CreateHost.Location = new System.Drawing.Point(15, 60);
            this.CreateHost.Name = "CreateHost";
            this.CreateHost.Size = new System.Drawing.Size(289, 23);
            this.CreateHost.TabIndex = 0;
            this.CreateHost.Text = "Create host";
            this.CreateHost.UseVisualStyleBackColor = true;
            this.CreateHost.Click += new System.EventHandler(this.CreateHost_Click);
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.Location = new System.Drawing.Point(12, 12);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(106, 17);
            this.nickname_label.TabIndex = 1;
            this.nickname_label.Text = "Your nickname:";
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(15, 32);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(289, 22);
            this.NickName.TabIndex = 2;
            // 
            // ipaddress_label
            // 
            this.ipaddress_label.AutoSize = true;
            this.ipaddress_label.Location = new System.Drawing.Point(12, 86);
            this.ipaddress_label.Name = "ipaddress_label";
            this.ipaddress_label.Size = new System.Drawing.Size(132, 17);
            this.ipaddress_label.TabIndex = 3;
            this.ipaddress_label.Text = "Remote IP address:";
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(15, 107);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(289, 22);
            this.IPAddress.TabIndex = 4;
            // 
            // ConnectRemoteHost
            // 
            this.ConnectRemoteHost.Location = new System.Drawing.Point(15, 136);
            this.ConnectRemoteHost.Name = "ConnectRemoteHost";
            this.ConnectRemoteHost.Size = new System.Drawing.Size(289, 23);
            this.ConnectRemoteHost.TabIndex = 5;
            this.ConnectRemoteHost.Text = "Connect remote host";
            this.ConnectRemoteHost.UseVisualStyleBackColor = true;
            this.ConnectRemoteHost.Click += new System.EventHandler(this.ConnectRemoteHost_Click);
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(212, 162);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(92, 17);
            this.version_label.TabIndex = 6;
            this.version_label.Text = "JustTalk v1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 183);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.ConnectRemoteHost);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.ipaddress_label);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.nickname_label);
            this.Controls.Add(this.CreateHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JustTalk";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateHost;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.Label ipaddress_label;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Button ConnectRemoteHost;
        private System.Windows.Forms.Label version_label;
    }
}