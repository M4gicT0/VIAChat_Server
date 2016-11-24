namespace VIAChatClient.Views
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.loginButton = new System.Windows.Forms.Button();
            this.creatAccountButton = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelInfoIntro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(260, 283);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(311, 39);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // creatAccountButton
            // 
            this.creatAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatAccountButton.Location = new System.Drawing.Point(260, 342);
            this.creatAccountButton.Name = "creatAccountButton";
            this.creatAccountButton.Size = new System.Drawing.Size(311, 42);
            this.creatAccountButton.TabIndex = 0;
            this.creatAccountButton.Text = "Create Account";
            this.creatAccountButton.UseVisualStyleBackColor = true;
            this.creatAccountButton.Click += new System.EventHandler(this.creatAccountButton_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcome.Location = new System.Drawing.Point(318, 182);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(208, 32);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome VIA Chat";
            // 
            // labelInfoIntro
            // 
            this.labelInfoIntro.AutoSize = true;
            this.labelInfoIntro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoIntro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfoIntro.Location = new System.Drawing.Point(325, 223);
            this.labelInfoIntro.Name = "labelInfoIntro";
            this.labelInfoIntro.Size = new System.Drawing.Size(201, 21);
            this.labelInfoIntro.TabIndex = 1;
            this.labelInfoIntro.Text = "Are you already a member?";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(864, 639);
            this.Controls.Add(this.labelInfoIntro);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.creatAccountButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIA Chat Messenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button creatAccountButton;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelInfoIntro;
    }
}

