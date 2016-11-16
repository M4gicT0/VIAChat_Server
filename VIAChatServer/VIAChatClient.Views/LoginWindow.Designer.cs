namespace VIAChatClient.Views
{
    partial class LoginWindow
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.hostIPlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.portlabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.logmeinButton = new System.Windows.Forms.Button();
            this.backMainwindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.userNameLabel.Location = new System.Drawing.Point(174, 146);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(162, 22);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username (ex. joe)";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(374, 150);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.passwordLabel.Location = new System.Drawing.Point(174, 188);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(89, 22);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(374, 192);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(229, 20);
            this.passwordtextBox.TabIndex = 1;
            // 
            // hostIPlabel
            // 
            this.hostIPlabel.AutoSize = true;
            this.hostIPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.hostIPlabel.Location = new System.Drawing.Point(174, 236);
            this.hostIPlabel.Name = "hostIPlabel";
            this.hostIPlabel.Size = new System.Drawing.Size(68, 22);
            this.hostIPlabel.TabIndex = 0;
            this.hostIPlabel.Text = "Host IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 1;
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.portlabel.Location = new System.Drawing.Point(469, 236);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(43, 22);
            this.portlabel.TabIndex = 0;
            this.portlabel.Text = "Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 1;
            // 
            // logmeinButton
            // 
            this.logmeinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logmeinButton.Location = new System.Drawing.Point(451, 307);
            this.logmeinButton.Name = "logmeinButton";
            this.logmeinButton.Size = new System.Drawing.Size(152, 44);
            this.logmeinButton.TabIndex = 2;
            this.logmeinButton.Text = "Login me in";
            this.logmeinButton.UseVisualStyleBackColor = true;
            // 
            // backMainwindowButton
            // 
            this.backMainwindowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMainwindowButton.Location = new System.Drawing.Point(178, 307);
            this.backMainwindowButton.Name = "backMainwindowButton";
            this.backMainwindowButton.Size = new System.Drawing.Size(152, 44);
            this.backMainwindowButton.TabIndex = 2;
            this.backMainwindowButton.Text = "Back to Main Window";
            this.backMainwindowButton.UseVisualStyleBackColor = true;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 640);
            this.Controls.Add(this.backMainwindowButton);
            this.Controls.Add(this.logmeinButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.portlabel);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.hostIPlabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label hostIPlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button logmeinButton;
        private System.Windows.Forms.Button backMainwindowButton;
    }
}