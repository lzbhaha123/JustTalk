namespace JustTalk
{
    partial class HostForm
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
            this.dialogRichBox = new System.Windows.Forms.RichTextBox();
            this.SentButton = new System.Windows.Forms.Button();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.IPaddressLabel = new System.Windows.Forms.Label();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dialogRichBox
            // 
            this.dialogRichBox.Location = new System.Drawing.Point(13, 50);
            this.dialogRichBox.Name = "dialogRichBox";
            this.dialogRichBox.ReadOnly = true;
            this.dialogRichBox.Size = new System.Drawing.Size(424, 290);
            this.dialogRichBox.TabIndex = 0;
            this.dialogRichBox.Text = "";
            // 
            // SentButton
            // 
            this.SentButton.Location = new System.Drawing.Point(362, 346);
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(75, 23);
            this.SentButton.TabIndex = 1;
            this.SentButton.Text = "Sent";
            this.SentButton.UseVisualStyleBackColor = true;
            this.SentButton.Click += new System.EventHandler(this.SentButton_Click);
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(13, 347);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(342, 22);
            this.MessageInput.TabIndex = 2;
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Location = new System.Drawing.Point(13, 13);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(78, 17);
            this.NicknameLabel.TabIndex = 3;
            this.NicknameLabel.Text = "Nickname: ";
            // 
            // IPaddressLabel
            // 
            this.IPaddressLabel.AutoSize = true;
            this.IPaddressLabel.Location = new System.Drawing.Point(13, 30);
            this.IPaddressLabel.Name = "IPaddressLabel";
            this.IPaddressLabel.Size = new System.Drawing.Size(117, 17);
            this.IPaddressLabel.TabIndex = 4;
            this.IPaddressLabel.Text = "Your IP address: ";
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(136, 27);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.ReadOnly = true;
            this.IPAddressTextBox.Size = new System.Drawing.Size(301, 22);
            this.IPAddressTextBox.TabIndex = 5;
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 381);
            this.Controls.Add(this.IPAddressTextBox);
            this.Controls.Add(this.IPaddressLabel);
            this.Controls.Add(this.NicknameLabel);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.SentButton);
            this.Controls.Add(this.dialogRichBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HostForm";
            this.Text = "Chat Room";
            this.Load += new System.EventHandler(this.HostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dialogRichBox;
        private System.Windows.Forms.Button SentButton;
        private System.Windows.Forms.TextBox MessageInput;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label IPaddressLabel;
        private System.Windows.Forms.TextBox IPAddressTextBox;
    }
}