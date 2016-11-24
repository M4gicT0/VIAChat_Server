namespace VIAChatClient
{
    partial class FormMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.headerMainlabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.statementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerMainlabel
            // 
            this.headerMainlabel.AutoSize = true;
            this.headerMainlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerMainlabel.ForeColor = System.Drawing.Color.White;
            this.headerMainlabel.Location = new System.Drawing.Point(372, 185);
            this.headerMainlabel.Name = "headerMainlabel";
            this.headerMainlabel.Size = new System.Drawing.Size(226, 25);
            this.headerMainlabel.TabIndex = 0;
            this.headerMainlabel.Text = "Do you have an account?";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(345, 276);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(302, 56);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(345, 349);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(302, 56);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create an Account";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // statementLabel
            // 
            this.statementLabel.AutoSize = true;
            this.statementLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.statementLabel.ForeColor = System.Drawing.Color.White;
            this.statementLabel.Location = new System.Drawing.Point(440, 210);
            this.statementLabel.Name = "statementLabel";
            this.statementLabel.Size = new System.Drawing.Size(77, 13);
            this.statementLabel.TabIndex = 0;
            this.statementLabel.Text = "Send, Receive";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(944, 552);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.statementLabel);
            this.Controls.Add(this.headerMainlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIA Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerMainlabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label statementLabel;
    }
}

