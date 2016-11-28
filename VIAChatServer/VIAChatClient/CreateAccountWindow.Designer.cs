namespace VIAChatClient
{
    partial class CreateAccountWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.registerMeButton = new System.Windows.Forms.Button();
            this.backToMainButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.hostIPAddresslabelCreate = new System.Windows.Forms.Label();
            this.portTextBoxCreate = new System.Windows.Forms.TextBox();
            this.hostIPAddressTextBoxCreate = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register your account";
            // 
            // registerMeButton
            // 
            this.registerMeButton.ForeColor = System.Drawing.Color.Black;
            this.registerMeButton.Location = new System.Drawing.Point(512, 360);
            this.registerMeButton.Name = "registerMeButton";
            this.registerMeButton.Size = new System.Drawing.Size(238, 45);
            this.registerMeButton.TabIndex = 6;
            this.registerMeButton.Text = "Register me";
            this.registerMeButton.UseVisualStyleBackColor = true;
            this.registerMeButton.Click += new System.EventHandler(this.registerMeButton_Click);
            // 
            // backToMainButton
            // 
            this.backToMainButton.ForeColor = System.Drawing.Color.Black;
            this.backToMainButton.Location = new System.Drawing.Point(247, 360);
            this.backToMainButton.Name = "backToMainButton";
            this.backToMainButton.Size = new System.Drawing.Size(238, 45);
            this.backToMainButton.TabIndex = 7;
            this.backToMainButton.Text = "Back";
            this.backToMainButton.UseVisualStyleBackColor = true;
            this.backToMainButton.Click += new System.EventHandler(this.backToMainButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(525, 152);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(225, 29);
            this.userTextBox.TabIndex = 1;
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.userNamelabel.Location = new System.Drawing.Point(250, 152);
            this.userNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(186, 25);
            this.userNamelabel.TabIndex = 0;
            this.userNamelabel.Text = "User Name  ( ex. joe)";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.emailLabel.Location = new System.Drawing.Point(250, 207);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(268, 25);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email  ( ex. joe@example.com)";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(525, 200);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(225, 29);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.passwordLabel.Location = new System.Drawing.Point(250, 258);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 25);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(525, 251);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(225, 29);
            this.passwordTextBox.TabIndex = 3;
            // 
            // hostIPAddresslabelCreate
            // 
            this.hostIPAddresslabelCreate.AutoSize = true;
            this.hostIPAddresslabelCreate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.hostIPAddresslabelCreate.Location = new System.Drawing.Point(250, 296);
            this.hostIPAddresslabelCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostIPAddresslabelCreate.Name = "hostIPAddresslabelCreate";
            this.hostIPAddresslabelCreate.Size = new System.Drawing.Size(71, 25);
            this.hostIPAddresslabelCreate.TabIndex = 0;
            this.hostIPAddresslabelCreate.Text = "Host IP";
            // 
            // portTextBoxCreate
            // 
            this.portTextBoxCreate.Location = new System.Drawing.Point(658, 289);
            this.portTextBoxCreate.MaxLength = 5;
            this.portTextBoxCreate.Name = "portTextBoxCreate";
            this.portTextBoxCreate.Size = new System.Drawing.Size(92, 29);
            this.portTextBoxCreate.TabIndex = 5;
            this.portTextBoxCreate.Text = "1234";
            // 
            // hostIPAddressTextBoxCreate
            // 
            this.hostIPAddressTextBoxCreate.Location = new System.Drawing.Point(328, 289);
            this.hostIPAddressTextBoxCreate.MaxLength = 11;
            this.hostIPAddressTextBoxCreate.Name = "hostIPAddressTextBoxCreate";
            this.hostIPAddressTextBoxCreate.Size = new System.Drawing.Size(225, 29);
            this.hostIPAddressTextBoxCreate.TabIndex = 4;
            this.hostIPAddressTextBoxCreate.Text = "127.0.0.1";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.portLabel.Location = new System.Drawing.Point(591, 296);
            this.portLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(46, 25);
            this.portLabel.TabIndex = 0;
            this.portLabel.Text = "Port";
            // 
            // CreateAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(985, 562);
            this.Controls.Add(this.hostIPAddressTextBoxCreate);
            this.Controls.Add(this.portTextBoxCreate);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.hostIPAddresslabelCreate);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.backToMainButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerMeButton);
            this.Controls.Add(this.userNamelabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateAccountWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerMeButton;
        private System.Windows.Forms.Button backToMainButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label hostIPAddresslabelCreate;
        private System.Windows.Forms.TextBox portTextBoxCreate;
        private System.Windows.Forms.TextBox hostIPAddressTextBoxCreate;
        private System.Windows.Forms.Label portLabel;
    }
}