namespace VIAChatClient
{
    partial class LoginFormUserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormUserWindow));
            this.headerLabel = new System.Windows.Forms.Label();
            this.userNameTextBoxLog = new System.Windows.Forms.TextBox();
            this.userNameLabelLog = new System.Windows.Forms.Label();
            this.passwordLabelLog = new System.Windows.Forms.Label();
            this.passwordTextBoxLog = new System.Windows.Forms.TextBox();
            this.ipAddressLabelLog = new System.Windows.Forms.Label();
            this.ipAddressTextBoxLog = new System.Windows.Forms.TextBox();
            this.portTextBoxLog = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.logMeInButtonLog = new System.Windows.Forms.Button();
            this.backbButtonLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(298, 44);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(143, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Login to Chat";
            // 
            // userNameTextBoxLog
            // 
            this.userNameTextBoxLog.Location = new System.Drawing.Point(331, 154);
            this.userNameTextBoxLog.Name = "userNameTextBoxLog";
            this.userNameTextBoxLog.Size = new System.Drawing.Size(367, 22);
            this.userNameTextBoxLog.TabIndex = 1;
            // 
            // userNameLabelLog
            // 
            this.userNameLabelLog.AutoSize = true;
            this.userNameLabelLog.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.userNameLabelLog.Location = new System.Drawing.Point(183, 154);
            this.userNameLabelLog.Name = "userNameLabelLog";
            this.userNameLabelLog.Size = new System.Drawing.Size(102, 25);
            this.userNameLabelLog.TabIndex = 0;
            this.userNameLabelLog.Text = "User name";
            // 
            // passwordLabelLog
            // 
            this.passwordLabelLog.AutoSize = true;
            this.passwordLabelLog.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.passwordLabelLog.Location = new System.Drawing.Point(183, 201);
            this.passwordLabelLog.Name = "passwordLabelLog";
            this.passwordLabelLog.Size = new System.Drawing.Size(91, 25);
            this.passwordLabelLog.TabIndex = 0;
            this.passwordLabelLog.Text = "Password";
            // 
            // passwordTextBoxLog
            // 
            this.passwordTextBoxLog.Location = new System.Drawing.Point(331, 201);
            this.passwordTextBoxLog.Name = "passwordTextBoxLog";
            this.passwordTextBoxLog.PasswordChar = '*';
            this.passwordTextBoxLog.Size = new System.Drawing.Size(367, 22);
            this.passwordTextBoxLog.TabIndex = 1;
            // 
            // ipAddressLabelLog
            // 
            this.ipAddressLabelLog.AutoSize = true;
            this.ipAddressLabelLog.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.ipAddressLabelLog.Location = new System.Drawing.Point(183, 250);
            this.ipAddressLabelLog.Name = "ipAddressLabelLog";
            this.ipAddressLabelLog.Size = new System.Drawing.Size(100, 25);
            this.ipAddressLabelLog.TabIndex = 0;
            this.ipAddressLabelLog.Text = "IP Address";
            // 
            // ipAddressTextBoxLog
            // 
            this.ipAddressTextBoxLog.Location = new System.Drawing.Point(331, 250);
            this.ipAddressTextBoxLog.MaxLength = 11;
            this.ipAddressTextBoxLog.Name = "ipAddressTextBoxLog";
            this.ipAddressTextBoxLog.Size = new System.Drawing.Size(171, 22);
            this.ipAddressTextBoxLog.TabIndex = 1;
            // 
            // portTextBoxLog
            // 
            this.portTextBoxLog.Location = new System.Drawing.Point(581, 250);
            this.portTextBoxLog.MaxLength = 5;
            this.portTextBoxLog.Name = "portTextBoxLog";
            this.portTextBoxLog.Size = new System.Drawing.Size(117, 22);
            this.portTextBoxLog.TabIndex = 1;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.portLabel.Location = new System.Drawing.Point(529, 250);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(46, 25);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port";
            // 
            // logMeInButtonLog
            // 
            this.logMeInButtonLog.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.logMeInButtonLog.ForeColor = System.Drawing.Color.Black;
            this.logMeInButtonLog.Location = new System.Drawing.Point(477, 361);
            this.logMeInButtonLog.Name = "logMeInButtonLog";
            this.logMeInButtonLog.Size = new System.Drawing.Size(221, 59);
            this.logMeInButtonLog.TabIndex = 2;
            this.logMeInButtonLog.Text = "Log me in ";
            this.logMeInButtonLog.UseVisualStyleBackColor = true;
            this.logMeInButtonLog.Click += new System.EventHandler(this.logMeInButtonLog_Click);
            // 
            // backbButtonLog
            // 
            this.backbButtonLog.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.backbButtonLog.ForeColor = System.Drawing.Color.Black;
            this.backbButtonLog.Location = new System.Drawing.Point(188, 361);
            this.backbButtonLog.Name = "backbButtonLog";
            this.backbButtonLog.Size = new System.Drawing.Size(221, 59);
            this.backbButtonLog.TabIndex = 2;
            this.backbButtonLog.Text = "Back";
            this.backbButtonLog.UseVisualStyleBackColor = true;
            this.backbButtonLog.Click += new System.EventHandler(this.backbButtonLog_Click);
            // 
            // LoginFormUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(857, 615);
            this.Controls.Add(this.backbButtonLog);
            this.Controls.Add(this.logMeInButtonLog);
            this.Controls.Add(this.portTextBoxLog);
            this.Controls.Add(this.ipAddressTextBoxLog);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipAddressLabelLog);
            this.Controls.Add(this.passwordTextBoxLog);
            this.Controls.Add(this.passwordLabelLog);
            this.Controls.Add(this.userNameTextBoxLog);
            this.Controls.Add(this.userNameLabelLog);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginFormUserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox userNameTextBoxLog;
        private System.Windows.Forms.Label userNameLabelLog;
        private System.Windows.Forms.Label passwordLabelLog;
        private System.Windows.Forms.TextBox passwordTextBoxLog;
        private System.Windows.Forms.Label ipAddressLabelLog;
        private System.Windows.Forms.TextBox ipAddressTextBoxLog;
        private System.Windows.Forms.TextBox portTextBoxLog;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button logMeInButtonLog;
        private System.Windows.Forms.Button backbButtonLog;
    }
}