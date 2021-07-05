namespace ChatOnline
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConfirmation = new System.Windows.Forms.Label();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblPasswordConfirmationError = new System.Windows.Forms.Label();
            this.lblSaved = new System.Windows.Forms.Label();
            this.linkAuthentication = new System.Windows.Forms.LinkLabel();
            this.pctForm = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(95, 92);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 27);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(95, 159);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 27);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(95, 228);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 27);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // lblPasswordConfirmation
            // 
            this.lblPasswordConfirmation.AutoSize = true;
            this.lblPasswordConfirmation.Location = new System.Drawing.Point(95, 298);
            this.lblPasswordConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordConfirmation.Name = "lblPasswordConfirmation";
            this.lblPasswordConfirmation.Size = new System.Drawing.Size(212, 27);
            this.lblPasswordConfirmation.TabIndex = 3;
            this.lblPasswordConfirmation.Text = "Password Confirmation :";
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(95, 367);
            this.lblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(78, 27);
            this.lblPhoto.TabIndex = 4;
            this.lblPhoto.Text = "Picture :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(172, 122);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(260, 34);
            this.txtLogin.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(172, 188);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 34);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(172, 259);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 34);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(172, 330);
            this.txtPasswordConfirmation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(260, 34);
            this.txtPasswordConfirmation.TabIndex = 8;
            this.txtPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnUploadImg.Location = new System.Drawing.Point(172, 390);
            this.btnUploadImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(260, 34);
            this.btnUploadImg.TabIndex = 9;
            this.btnUploadImg.Text = "Upload";
            this.btnUploadImg.UseVisualStyleBackColor = false;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Location = new System.Drawing.Point(205, 455);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 46);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLoginError
            // 
            this.lblLoginError.AutoSize = true;
            this.lblLoginError.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginError.ForeColor = System.Drawing.Color.Red;
            this.lblLoginError.Location = new System.Drawing.Point(440, 120);
            this.lblLoginError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(23, 38);
            this.lblLoginError.TabIndex = 11;
            this.lblLoginError.Text = "!";
            this.lblLoginError.Visible = false;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(440, 188);
            this.lblEmailError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(23, 38);
            this.lblEmailError.TabIndex = 12;
            this.lblEmailError.Text = "!";
            this.lblEmailError.Visible = false;
            this.lblEmailError.Click += new System.EventHandler(this.lblEmailError_Click);
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(440, 260);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(23, 38);
            this.lblPasswordError.TabIndex = 13;
            this.lblPasswordError.Text = "!";
            this.lblPasswordError.Visible = false;
            // 
            // lblPasswordConfirmationError
            // 
            this.lblPasswordConfirmationError.AutoSize = true;
            this.lblPasswordConfirmationError.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfirmationError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordConfirmationError.Location = new System.Drawing.Point(440, 330);
            this.lblPasswordConfirmationError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordConfirmationError.Name = "lblPasswordConfirmationError";
            this.lblPasswordConfirmationError.Size = new System.Drawing.Size(23, 38);
            this.lblPasswordConfirmationError.TabIndex = 14;
            this.lblPasswordConfirmationError.Text = "!";
            this.lblPasswordConfirmationError.Visible = false;
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Location = new System.Drawing.Point(390, 465);
            this.lblSaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(116, 27);
            this.lblSaved.TabIndex = 15;
            this.lblSaved.Text = "User saved !";
            this.lblSaved.Visible = false;
            // 
            // linkAuthentication
            // 
            this.linkAuthentication.AutoSize = true;
            this.linkAuthentication.Location = new System.Drawing.Point(227, 506);
            this.linkAuthentication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAuthentication.Name = "linkAuthentication";
            this.linkAuthentication.Size = new System.Drawing.Size(135, 27);
            this.linkAuthentication.TabIndex = 16;
            this.linkAuthentication.TabStop = true;
            this.linkAuthentication.Text = "Authentication";
            this.linkAuthentication.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAuthentication_LinkClicked);
            // 
            // pctForm
            // 
            this.pctForm.Image = global::ChatOnline.Properties.Resources.form;
            this.pctForm.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctForm.InitialImage")));
            this.pctForm.Location = new System.Drawing.Point(-3, 0);
            this.pctForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pctForm.Name = "pctForm";
            this.pctForm.Size = new System.Drawing.Size(522, 571);
            this.pctForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctForm.TabIndex = 17;
            this.pctForm.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitle.Location = new System.Drawing.Point(174, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 69);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Inscription";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(519, 571);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.linkAuthentication);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.lblPasswordConfirmationError);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblLoginError);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblPasswordConfirmation);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pctForm);
            this.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.pctForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordConfirmation;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblPasswordConfirmationError;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.LinkLabel linkAuthentication;
        private System.Windows.Forms.PictureBox pctForm;
        private System.Windows.Forms.Label lblTitle;
    }
}