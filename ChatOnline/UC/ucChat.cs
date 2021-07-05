using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatOnline.Model;

namespace ChatOnline.UC
{
    public partial class ucChat : UserControl
    {
        public int IdDiscussion { get; set; }
        public String Message { get; set; }
        public DateTime DateDiscussion { get; set; }
        public User User { get; set; }

        public ucChat()
        {
            InitializeComponent();
        }
        public ucChat(int IdDiscussion, String Message, DateTime DateDiscussion, User User)
        {
            InitializeComponent();
            this.IdDiscussion = IdDiscussion;
            this.Message = Message;
            this.DateDiscussion = DateDiscussion;
            this.User = User;

            lblLogin.Text = this.User.Login;
            lblMessage.Text = this.Message;
            lblDate.Text = this.DateDiscussion.ToString();
        }
    }
}
