namespace ChatOnline
{
    partial class Authentication
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblWorked = new System.Windows.Forms.Label();
            this.linkInscription = new System.Windows.Forms.LinkLabel();
            this.pctForm = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(76, 104);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(60, 22);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(76, 168);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 22);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(143, 130);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(236, 29);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(143, 198);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(236, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogin.Location = new System.Drawing.Point(186, 269);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 47);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(147, 240);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(201, 22);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Invalid Login or Password !";
            this.lblError.Visible = false;
            // 
            // lblWorked
            // 
            this.lblWorked.AutoSize = true;
            this.lblWorked.Location = new System.Drawing.Point(337, 286);
            this.lblWorked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorked.Name = "lblWorked";
            this.lblWorked.Size = new System.Drawing.Size(62, 22);
            this.lblWorked.TabIndex = 7;
            this.lblWorked.Text = "Great !";
            this.lblWorked.Visible = false;
            // 
            // linkInscription
            // 
            this.linkInscription.AutoSize = true;
            this.linkInscription.Location = new System.Drawing.Point(204, 321);
            this.linkInscription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkInscription.Name = "linkInscription";
            this.linkInscription.Size = new System.Drawing.Size(86, 22);
            this.linkInscription.TabIndex = 8;
            this.linkInscription.TabStop = true;
            this.linkInscription.Text = "Inscription";
            this.linkInscription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInscription_LinkClicked);
            // 
            // pctForm
            // 
            this.pctForm.Image = global::ChatOnline.Properties.Resources.form;
            this.pctForm.InitialImage = null;
            this.pctForm.Location = new System.Drawing.Point(0, -2);
            this.pctForm.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pctForm.Name = "pctForm";
            this.pctForm.Size = new System.Drawing.Size(473, 411);
            this.pctForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctForm.TabIndex = 18;
            this.pctForm.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitle.Location = new System.Drawing.Point(86, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 55);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Authentication";
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(473, 410);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.linkInscription);
            this.Controls.Add(this.lblWorked);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pctForm);
            this.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Authentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblWorked;
        private System.Windows.Forms.LinkLabel linkInscription;
        private System.Windows.Forms.PictureBox pctForm;
        private System.Windows.Forms.Label lblTitle;
    }
}

