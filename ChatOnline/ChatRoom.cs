using ChatOnline.Model;
using ChatOnline.UC;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatOnline
{
    public partial class ChatRoom : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("Server=localhost; Port=5432;User Id=postgres; Password=hafsa; Database=ChatOnline");
        public List<Discussion> Discussions { get; set; }
        public List<User> Users { get; set; }
        public List<ucChat> Chats { get; set; }
        public List<ucUser> UCUsers { get; set; }
        public int ticks;
        public ChatRoom()
        {
            InitializeComponent();
            lblLogin.Text = Authentication.MyUser.Login;
            Load_Discussions();
            Load_Users();
            timer.Start();
        }

        public void Load_Discussions()
        {
            if (!cnx.State.Equals(ConnectionState.Open))
                cnx.Open();
            String qry = "SELECT \"idDiscussion\", \"message\", \"date\", \"idUser\" FROM public.\"Discussion\"";
            NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
            var reader = cmd.ExecuteReader();
            Discussions = new List<Discussion>();
            while (reader.Read())
            {
                Discussions.Add(new Discussion(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), User.GetUserById(reader.GetInt32(3))));
            }
            reader.Close();
            cnx.Close();

            Chats = new List<ucChat>();
            foreach (Discussion discussion in Discussions)
            {
                Chats.Add(new ucChat(discussion.IdDiscussion, discussion.Message, discussion.DateDiscussion, discussion.User));
            }

            flowPnlChat.Controls.Clear();
            foreach (ucChat chat in Chats)
            {
                flowPnlChat.Controls.Add(chat);
            }
        }

        public void Load_Users()
        {
            if (!cnx.State.Equals(ConnectionState.Open))
                cnx.Open();
            String qry = "SELECT \"idUser\", \"login\", \"imgUser\", \"loggedIn\" FROM public.\"User\" where \"idUser\" != '" + Authentication.MyUser.IdUser + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
            var reader = cmd.ExecuteReader();
            Users = new List<User>();
            while (reader.Read())
            {
                Users.Add(new User(reader.GetInt32(0), reader.GetString(1), (byte[])reader.GetValue(2), (int)reader.GetValue(3)));
            }
            reader.Close();
            cnx.Close();

            UCUsers = new List<ucUser>();
            foreach (User user in Users)
            {
                UCUsers.Add(new ucUser(user.IdUser, user.Login, user.Photo, user.LoggedIn));
            }

            flowPnlUsers.Controls.Clear();
            foreach (ucUser user in UCUsers)
            {
                flowPnlUsers.Controls.Add(user);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = DateTime.UtcNow;
                if (!cnx.State.Equals(ConnectionState.Open))
                    cnx.Open();
                String qry = "insert into public.\"Discussion\" (\"message\", \"date\", \"idUser\") Values ('" + txtMessage.Text + "', :date, '" + Authentication.MyUser.IdUser + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                NpgsqlParameter param = new NpgsqlParameter(":date", NpgsqlTypes.NpgsqlDbType.Timestamp);
                param.Value = dt;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                cnx.Close();
                Load_Discussions();
            }
            catch (NpgsqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (!cnx.State.Equals(ConnectionState.Open))
                cnx.Open();
            string req = "update public.\"User\" set \"loggedIn\" = '" + 0 + "' where \"idUser\" = '" + Authentication.MyUser.IdUser + "'";
            NpgsqlCommand cmdLoggedIn = new NpgsqlCommand(req, cnx);
            cmdLoggedIn.ExecuteNonQuery();
            cnx.Close();
            this.Hide();
            Authentication authentication = new Authentication();
            authentication.Show();
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks % 100 == 0)
            {
                Load_Discussions();
                Load_Users();
            }
        }
    }
}
