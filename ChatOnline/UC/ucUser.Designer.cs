namespace ChatOnline.UC
{
    partial class ucUser
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pnlActive = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(55, 17);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(59, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // pictureUser
            // 
            this.pictureUser.Image = global::ChatOnline.Properties.Resources.klipartz1;
            this.pictureUser.Location = new System.Drawing.Point(0, -3);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(52, 63);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 1;
            this.pictureUser.TabStop = false;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlActive.Location = new System.Drawing.Point(-1, -1);
            this.pnlActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(10, 11);
            this.pnlActive.TabIndex = 2;
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(115, 57);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Panel pnlActive;
    }
}
