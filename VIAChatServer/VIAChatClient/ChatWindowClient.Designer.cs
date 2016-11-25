namespace VIAChatClient
{
    partial class ChatWindowClient
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
            this.ChatMessageRichTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.inputMessageToSendTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.headerConversationlabel = new System.Windows.Forms.Label();
            this.headeronlineUsersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChatMessageRichTextBoxDisplay
            // 
            this.ChatMessageRichTextBoxDisplay.Location = new System.Drawing.Point(32, 53);
            this.ChatMessageRichTextBoxDisplay.Name = "ChatMessageRichTextBoxDisplay";
            this.ChatMessageRichTextBoxDisplay.ReadOnly = true;
            this.ChatMessageRichTextBoxDisplay.Size = new System.Drawing.Size(513, 454);
            this.ChatMessageRichTextBoxDisplay.TabIndex = 0;
            this.ChatMessageRichTextBoxDisplay.Text = "";
            // 
            // inputMessageToSendTextBox
            // 
            this.inputMessageToSendTextBox.Location = new System.Drawing.Point(32, 522);
            this.inputMessageToSendTextBox.Multiline = true;
            this.inputMessageToSendTextBox.Name = "inputMessageToSendTextBox";
            this.inputMessageToSendTextBox.Size = new System.Drawing.Size(513, 77);
            this.inputMessageToSendTextBox.TabIndex = 1;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.Location = new System.Drawing.Point(574, 535);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(173, 64);
            this.sendMessageButton.TabIndex = 3;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(574, 60);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(173, 459);
            this.userListBox.TabIndex = 4;
            // 
            // headerConversationlabel
            // 
            this.headerConversationlabel.AutoSize = true;
            this.headerConversationlabel.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.headerConversationlabel.ForeColor = System.Drawing.Color.White;
            this.headerConversationlabel.Location = new System.Drawing.Point(28, 27);
            this.headerConversationlabel.Name = "headerConversationlabel";
            this.headerConversationlabel.Size = new System.Drawing.Size(110, 23);
            this.headerConversationlabel.TabIndex = 5;
            this.headerConversationlabel.Text = "Conversation";
            // 
            // headeronlineUsersLabel
            // 
            this.headeronlineUsersLabel.AutoSize = true;
            this.headeronlineUsersLabel.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.headeronlineUsersLabel.ForeColor = System.Drawing.Color.White;
            this.headeronlineUsersLabel.Location = new System.Drawing.Point(570, 34);
            this.headeronlineUsersLabel.Name = "headeronlineUsersLabel";
            this.headeronlineUsersLabel.Size = new System.Drawing.Size(99, 23);
            this.headeronlineUsersLabel.TabIndex = 5;
            this.headeronlineUsersLabel.Text = "Online User";
            // 
            // ChatWindowClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(793, 636);
            this.Controls.Add(this.headeronlineUsersLabel);
            this.Controls.Add(this.headerConversationlabel);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.inputMessageToSendTextBox);
            this.Controls.Add(this.ChatMessageRichTextBoxDisplay);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChatWindowClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatMessageRichTextBoxDisplay;
        private System.Windows.Forms.TextBox inputMessageToSendTextBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label headerConversationlabel;
        private System.Windows.Forms.Label headeronlineUsersLabel;
    }
}