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
            this.registerByCreatingAccountbutton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username (ex. joe)";
            // 
            // userNameTextBoxCreate
            // 
            this.userNameTextBoxCreate.Location = new System.Drawing.Point(461, 114);
            this.userNameTextBoxCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameTextBoxCreate.Name = "userNameTextBoxCreate";
            this.userNameTextBoxCreate.Size = new System.Drawing.Size(356, 27);
            this.userNameTextBoxCreate.TabIndex = 1;
            // 
            // passwordLabelCreate
            // 
            this.passwordLabelCreate.AutoSize = true;
            this.passwordLabelCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelCreate.ForeColor = System.Drawing.Color.White;
            this.passwordLabelCreate.Location = new System.Drawing.Point(206, 165);
            this.passwordLabelCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabelCreate.Name = "passwordLabelCreate";
            this.passwordLabelCreate.Size = new System.Drawing.Size(91, 25);
            this.passwordLabelCreate.TabIndex = 0;
            this.passwordLabelCreate.Text = "Password";
            // 
            // passwordTextBoxCreate
            // 
            this.passwordTextBoxCreate.Location = new System.Drawing.Point(461, 171);
            this.passwordTextBoxCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBoxCreate.Name = "passwordTextBoxCreate";
            this.passwordTextBoxCreate.PasswordChar = '*';
            this.passwordTextBoxCreate.Size = new System.Drawing.Size(356, 27);
            this.passwordTextBoxCreate.TabIndex = 1;
            // 
            // repeatPasswordLabelCreate
            // 
            this.repeatPasswordLabelCreate.AutoSize = true;
            this.repeatPasswordLabelCreate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordLabelCreate.ForeColor = System.Drawing.Color.White;
            this.repeatPasswordLabelCreate.Location = new System.Drawing.Point(206, 225);
            this.repeatPasswordLabelCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.repeatPasswordLabelCreate.Name = "repeatPasswordLabelCreate";
            this.repeatPasswordLabelCreate.Size = new System.Drawing.Size(153, 25);
            this.repeatPasswordLabelCreate.TabIndex = 0;
            this.repeatPasswordLabelCreate.Text = "Repeat Password";
            // 
            // repeatpasswordTextBoxCreate
            // 
            this.repeatpasswordTextBoxCreate.Location = new System.Drawing.Point(461, 231);
            this.repeatpasswordTextBoxCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repeatpasswordTextBoxCreate.Name = "repeatpasswordTextBoxCreate";
            this.repeatpasswordTextBoxCreate.PasswordChar = '*';
            this.repeatpasswordTextBoxCreate.Size = new System.Drawing.Size(356, 27);
            this.repeatpasswordTextBoxCreate.TabIndex = 1;
            // 
            // registerByCreatingAccountbutton
            // 
            this.registerByCreatingAccountbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerByCreatingAccountbutton.Location = new System.Drawing.Point(600, 368);
            this.registerByCreatingAccountbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.registerByCreatingAccountbutton.Name = "registerByCreatingAccountbutton";
            this.registerByCreatingAccountbutton.Size = new System.Drawing.Size(217, 68);
            this.registerByCreatingAccountbutton.TabIndex = 2;
            this.registerByCreatingAccountbutton.Text = "Create Account";
            this.registerByCreatingAccountbutton.UseVisualStyleBackColor = true;
            this.registerByCreatingAccountbutton.Click += new System.EventHandler(this.registerByCreatingAccountbutton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(228, 368);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(217, 67);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // CreateAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1038, 542);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerByCreatingAccountbutton);
            this.Controls.Add(this.repeatpasswordTextBoxCreate);
            this.Controls.Add(this.passwordTextBoxCreate);
            this.Controls.Add(this.userNameTextBoxCreate);
            this.Controls.Add(this.repeatPasswordLabelCreate);
            this.Controls.Add(this.passwordLabelCreate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button registerByCreatingAccountbutton;
        private System.Windows.Forms.Button backButton;
    }
}