namespace VIAChatServer
{
    partial class Monitor
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonToggle = new System.Windows.Forms.Button();
            this.messagesBox = new System.Windows.Forms.TextBox();
            this.adminInput = new System.Windows.Forms.TextBox();
            this.usersList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonToggle
            // 
            this.buttonToggle.Location = new System.Drawing.Point(12, 435);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(114, 31);
            this.buttonToggle.TabIndex = 0;
            this.buttonToggle.Text = "Start";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // messagesBox
            // 
            this.messagesBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.messagesBox.Location = new System.Drawing.Point(13, 13);
            this.messagesBox.Multiline = true;
            this.messagesBox.Name = "messagesBox";
            this.messagesBox.ReadOnly = true;
            this.messagesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesBox.Size = new System.Drawing.Size(622, 390);
            this.messagesBox.TabIndex = 1;
            this.messagesBox.WordWrap = false;
            // 
            // adminInput
            // 
            this.adminInput.Location = new System.Drawing.Point(13, 409);
            this.adminInput.Name = "adminInput";
            this.adminInput.Size = new System.Drawing.Size(866, 20);
            this.adminInput.TabIndex = 2;
            this.adminInput.Text = "Send to all";
            this.adminInput.TextChanged += new System.EventHandler(this.adminInput_TextChanged);
            // 
            // usersList
            // 
            this.usersList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usersList.Location = new System.Drawing.Point(641, 13);
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.usersList.Size = new System.Drawing.Size(238, 390);
            this.usersList.TabIndex = 3;
            this.usersList.Text = "";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 478);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.adminInput);
            this.Controls.Add(this.messagesBox);
            this.Controls.Add(this.buttonToggle);
            this.Name = "Monitor";
            this.Text = "VIAChat Monitor";
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.TextBox messagesBox;
        private System.Windows.Forms.TextBox adminInput;
        private System.Windows.Forms.RichTextBox usersList;
    }
}

