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
            this.conversationBox = new System.Windows.Forms.RichTextBox();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.headerConversationlabel = new System.Windows.Forms.Label();
            this.headeronlineUsersLabel = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // conversationBox
            // 
            this.conversationBox.Location = new System.Drawing.Point(32, 53);
            this.conversationBox.Name = "conversationBox";
            this.conversationBox.ReadOnly = true;
            this.conversationBox.Size = new System.Drawing.Size(513, 454);
            this.conversationBox.TabIndex = 0;
            this.conversationBox.Text = "";
            // 
            // messageInput
            // 
            this.messageInput.Location = new System.Drawing.Point(32, 513);
            this.messageInput.Multiline = true;
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(513, 53);
            this.messageInput.TabIndex = 1;
            this.messageInput.TextChanged += new System.EventHandler(this.messageInput_TextChanged);
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Enabled = false;
            this.sendMessageButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageButton.Location = new System.Drawing.Point(574, 518);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(173, 48);
            this.sendMessageButton.TabIndex = 3;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
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
            this.headeronlineUsersLabel.Location = new System.Drawing.Point(570, 27);
            this.headeronlineUsersLabel.Name = "headeronlineUsersLabel";
            this.headeronlineUsersLabel.Size = new System.Drawing.Size(106, 23);
            this.headeronlineUsersLabel.TabIndex = 5;
            this.headeronlineUsersLabel.Text = "Online Users";
            // 
            // usersList
            // 
            this.usersList.Location = new System.Drawing.Point(574, 53);
            this.usersList.Multiline = true;
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.Size = new System.Drawing.Size(173, 454);
            this.usersList.TabIndex = 6;
            // 
            // ChatWindowClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(793, 636);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.headeronlineUsersLabel);
            this.Controls.Add(this.headerConversationlabel);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.conversationBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChatWindowClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox conversationBox;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Label headerConversationlabel;
        private System.Windows.Forms.Label headeronlineUsersLabel;
        private System.Windows.Forms.TextBox usersList;
    }
}