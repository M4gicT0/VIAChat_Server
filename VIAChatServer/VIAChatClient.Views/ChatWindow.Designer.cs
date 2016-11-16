namespace VIAChatClient.Views
{
    partial class Chat
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
            this.userprofilePanel = new System.Windows.Forms.Panel();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textReceivedrichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputTextBoxToSend = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.userprofilePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userprofilePanel
            // 
            this.userprofilePanel.Controls.Add(this.userNamelabel);
            this.userprofilePanel.Location = new System.Drawing.Point(44, 12);
            this.userprofilePanel.Name = "userprofilePanel";
            this.userprofilePanel.Size = new System.Drawing.Size(297, 103);
            this.userprofilePanel.TabIndex = 0;
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelabel.Location = new System.Drawing.Point(113, 18);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(40, 25);
            this.userNamelabel.TabIndex = 0;
            this.userNamelabel.Text = "Joe";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 644);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Users";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(15, 46);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(265, 524);
            this.userListBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendButton);
            this.panel2.Controls.Add(this.inputTextBoxToSend);
            this.panel2.Controls.Add(this.textReceivedrichTextBox);
            this.panel2.Location = new System.Drawing.Point(44, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 429);
            this.panel2.TabIndex = 2;
            // 
            // textReceivedrichTextBox
            // 
            this.textReceivedrichTextBox.Location = new System.Drawing.Point(0, 3);
            this.textReceivedrichTextBox.Name = "textReceivedrichTextBox";
            this.textReceivedrichTextBox.ReadOnly = true;
            this.textReceivedrichTextBox.Size = new System.Drawing.Size(396, 333);
            this.textReceivedrichTextBox.TabIndex = 0;
            this.textReceivedrichTextBox.Text = "";
            // 
            // inputTextBoxToSend
            // 
            this.inputTextBoxToSend.Location = new System.Drawing.Point(3, 360);
            this.inputTextBoxToSend.Multiline = true;
            this.inputTextBoxToSend.Name = "inputTextBoxToSend";
            this.inputTextBoxToSend.Size = new System.Drawing.Size(294, 66);
            this.inputTextBoxToSend.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(312, 360);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(84, 48);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userprofilePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatWindow";
            this.userprofilePanel.ResumeLayout(false);
            this.userprofilePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userprofilePanel;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox inputTextBoxToSend;
        private System.Windows.Forms.RichTextBox textReceivedrichTextBox;
    }
}