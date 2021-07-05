using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChatOnline.UC
{
    public partial class ucUser : UserControl
    {
        public int IdUser { get; set; }
        public String Login { get; set; }
        public byte[] Photo { get; set; }
        public int LoggedIn { get; set; }
        public ucUser()
        {
            InitializeComponent();
        }

        public ucUser(int IdUser, String Login, byte[] Photo, int LoggedIn)
        {
            InitializeComponent();
            this.IdUser = IdUser;
            this.Login = Login;
            this.Photo = Photo;
            this.LoggedIn = LoggedIn;

            lblLogin.Text = this.Login;
            if (this.LoggedIn == 0)
                pnlActive.BackColor = Color.Red;
            else
                pnlActive.BackColor = Color.Green;
        }
    }
}
