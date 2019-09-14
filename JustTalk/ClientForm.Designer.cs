namespace JustTalk
{
    partial class ClientForm
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
            this.NicknameLabel = new System.Windows.Forms.Label();
            this.MessageInput = new System.Windows.Forms.TextBox();
            this.SentButton = new System.Windows.Forms.Button();
            this.dialogRichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NicknameLabel
            // 
            this.NicknameLabel.AutoSize = true;
            this.NicknameLabel.Location = new System.Drawing.Point(12, 9);
            this.NicknameLabel.Name = "NicknameLabel";
            this.NicknameLabel.Size = new System.Drawing.Size(78, 17);
            this.NicknameLabel.TabIndex = 4;
            this.NicknameLabel.Text = "Nickname: ";
            // 
            // MessageInput
            // 
            this.MessageInput.Location = new System.Drawing.Point(12, 347);
            this.MessageInput.Name = "MessageInput";
            this.MessageInput.Size = new System.Drawing.Size(342, 22);
            this.MessageInput.TabIndex = 5;
            // 
            // SentButton
            // 
            this.SentButton.Location = new System.Drawing.Point(362, 346);
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(75, 23);
            this.SentButton.TabIndex = 6;
            this.SentButton.Text = "Sent";
            this.SentButton.UseVisualStyleBackColor = true;
            // 
            // dialogRichBox
            // 
            this.dialogRichBox.Location = new System.Drawing.Point(12, 29);
            this.dialogRichBox.Name = "dialogRichBox";
            this.dialogRichBox.ReadOnly = true;
            this.dialogRichBox.Size = new System.Drawing.Size(424, 312);
            this.dialogRichBox.TabIndex = 7;
            this.dialogRichBox.Text = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 381);
            this.Controls.Add(this.dialogRichBox);
            this.Controls.Add(this.SentButton);
            this.Controls.Add(this.MessageInput);
            this.Controls.Add(this.NicknameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientForm";
            this.Text = "Chat Room";
            //this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.TextBox MessageInput;
        private System.Windows.Forms.Button SentButton;
        private System.Windows.Forms.RichTextBox dialogRichBox;
    }
}