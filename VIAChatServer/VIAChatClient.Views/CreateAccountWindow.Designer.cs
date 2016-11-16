namespace VIAChatClient.Views
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
            this.userNameTextBoxCreate = new System.Windows.Forms.TextBox();
            this.passwordLabelCreate = new System.Windows.Forms.Label();
            this.passwordTextBoxCreate = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabelCreate = new System.Windows.Forms.Label();
            this.repeatpasswordTextBoxCreate = new System.Windows.Forms.TextBox();
            this.registermeButton = new System.Windows.Forms.Button();
            this.backttomainwindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username (ex. joe)";
            // 
            // userNameTextBoxCreate
            // 
            this.userNameTextBoxCreate.Location = new System.Drawing.Point(327, 115);
            this.userNameTextBoxCreate.Name = "userNameTextBoxCreate";
            this.userNameTextBoxCreate.Size = new System.Drawing.Size(268, 20);
            this.userNameTextBoxCreate.TabIndex = 1;
            // 
            // passwordLabelCreate
            // 
            this.passwordLabelCreate.AutoSize = true;
            this.passwordLabelCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelCreate.Location = new System.Drawing.Point(136, 148);
            this.passwordLabelCreate.Name = "passwordLabelCreate";
            this.passwordLabelCreate.Size = new System.Drawing.Size(91, 25);
            this.passwordLabelCreate.TabIndex = 0;
            this.passwordLabelCreate.Text = "Password";
            // 
            // passwordTextBoxCreate
            // 
            this.passwordTextBoxCreate.Location = new System.Drawing.Point(327, 152);
            this.passwordTextBoxCreate.Name = "passwordTextBoxCreate";
            this.passwordTextBoxCreate.PasswordChar = '*';
            this.passwordTextBoxCreate.Size = new System.Drawing.Size(268, 20);
            this.passwordTextBoxCreate.TabIndex = 1;
            // 
            // repeatPasswordLabelCreate
            // 
            this.repeatPasswordLabelCreate.AutoSize = true;
            this.repeatPasswordLabelCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordLabelCreate.Location = new System.Drawing.Point(136, 187);
            this.repeatPasswordLabelCreate.Name = "repeatPasswordLabelCreate";
            this.repeatPasswordLabelCreate.Size = new System.Drawing.Size(153, 25);
            this.repeatPasswordLabelCreate.TabIndex = 0;
            this.repeatPasswordLabelCreate.Text = "Repeat Password";
            // 
            // repeatpasswordTextBoxCreate
            // 
            this.repeatpasswordTextBoxCreate.Location = new System.Drawing.Point(327, 191);
            this.repeatpasswordTextBoxCreate.Name = "repeatpasswordTextBoxCreate";
            this.repeatpasswordTextBoxCreate.PasswordChar = '*';
            this.repeatpasswordTextBoxCreate.Size = new System.Drawing.Size(268, 20);
            this.repeatpasswordTextBoxCreate.TabIndex = 1;
            // 
            // registermeButton
            // 
            this.registermeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registermeButton.Location = new System.Drawing.Point(432, 280);
            this.registermeButton.Name = "registermeButton";
            this.registermeButton.Size = new System.Drawing.Size(163, 44);
            this.registermeButton.TabIndex = 2;
            this.registermeButton.Text = "Register me";
            this.registermeButton.UseVisualStyleBackColor = true;
            // 
            // backttomainwindowButton
            // 
            this.backttomainwindowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backttomainwindowButton.Location = new System.Drawing.Point(141, 280);
            this.backttomainwindowButton.Name = "backttomainwindowButton";
            this.backttomainwindowButton.Size = new System.Drawing.Size(163, 44);
            this.backttomainwindowButton.TabIndex = 2;
            this.backttomainwindowButton.Text = "Back to main";
            this.backttomainwindowButton.UseVisualStyleBackColor = true;
            // 
            // CreateAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 643);
            this.Controls.Add(this.backttomainwindowButton);
            this.Controls.Add(this.registermeButton);
            this.Controls.Add(this.repeatpasswordTextBoxCreate);
            this.Controls.Add(this.passwordTextBoxCreate);
            this.Controls.Add(this.userNameTextBoxCreate);
            this.Controls.Add(this.repeatPasswordLabelCreate);
            this.Controls.Add(this.passwordLabelCreate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateAccountWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTextBoxCreate;
        private System.Windows.Forms.Label passwordLabelCreate;
        private System.Windows.Forms.TextBox passwordTextBoxCreate;
        private System.Windows.Forms.Label repeatPasswordLabelCreate;
        private System.Windows.Forms.TextBox repeatpasswordTextBoxCreate;
        private System.Windows.Forms.Button registermeButton;
        private System.Windows.Forms.Button backttomainwindowButton;
    }
}