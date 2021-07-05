namespace ChatOnline
{
    partial class ChatRoom
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
            this.components = new System.ComponentModel.Container();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.flowPnlChat = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPnlUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBackground = new System.Windows.Forms.PictureBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pictureDesign = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(13, 362);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(305, 37);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Honeydew;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(321, 362);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(52, 37);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblLogin.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(475, 25);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 19);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLogout.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(452, 362);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 28);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.Location = new System.Drawing.Point(278, 401);
            this.lblSaved.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(100, 18);
            this.lblSaved.TabIndex = 5;
            this.lblSaved.Text = "Message saved !";
            this.lblSaved.Visible = false;
            // 
            // flowPnlChat
            // 
            this.flowPnlChat.AutoScroll = true;
            this.flowPnlChat.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPnlChat.Location = new System.Drawing.Point(13, 74);
            this.flowPnlChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowPnlChat.Name = "flowPnlChat";
            this.flowPnlChat.Size = new System.Drawing.Size(360, 283);
            this.flowPnlChat.TabIndex = 6;
            // 
            // flowPnlUsers
            // 
            this.flowPnlUsers.AutoScroll = true;
            this.flowPnlUsers.Font = new System.Drawing.Font("Papyrus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowPnlUsers.Location = new System.Drawing.Point(377, 74);
            this.flowPnlUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowPnlUsers.Name = "flowPnlUsers";
            this.flowPnlUsers.Size = new System.Drawing.Size(176, 283);
            this.flowPnlUsers.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitle.Location = new System.Drawing.Point(9, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 55);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Chat Room";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBackground
            // 
            this.pictureBackground.Image = global::ChatOnline.Properties.Resources.klipartz_com__49_;
            this.pictureBackground.Location = new System.Drawing.Point(2, 0);
            this.pictureBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBackground.Name = "pictureBackground";
            this.pictureBackground.Size = new System.Drawing.Size(379, 426);
            this.pictureBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBackground.TabIndex = 21;
            this.pictureBackground.TabStop = false;
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureUser.Image = global::ChatOnline.Properties.Resources.klipartz_com__51_;
            this.pictureUser.Location = new System.Drawing.Point(452, 0);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(92, 72);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 8;
            this.pictureUser.TabStop = false;
            // 
            // pictureDesign
            // 
            this.pictureDesign.Image = global::ChatOnline.Properties.Resources.klipartz_com__52_;
            this.pictureDesign.Location = new System.Drawing.Point(377, 267);
            this.pictureDesign.Margin = new System.Windows.Forms.Padding(2);
            this.pictureDesign.Name = "pictureDesign";
            this.pictureDesign.Size = new System.Drawing.Size(176, 213);
            this.pictureDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDesign.TabIndex = 22;
            this.pictureDesign.TabStop = false;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(556, 427);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.flowPnlUsers);
            this.Controls.Add(this.flowPnlChat);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.pictureBackground);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.pictureDesign);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatRoom";
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.FlowLayoutPanel flowPnlChat;
        private System.Windows.Forms.FlowLayoutPanel flowPnlUsers;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBackground;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureDesign;
    }
}