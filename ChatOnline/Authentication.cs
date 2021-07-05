using ChatOnline.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatOnline
{
    public partial class Authentication : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("Server=localhost; Port=5432;User Id=postgres; Password=hafsa; Database=ChatOnline");
        public static User MyUser;
        public Authentication()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cnx.State.Equals(ConnectionState.Open))
                    cnx.Open();
                String qry = "SELECT \"idUser\", \"login\", \"imgUser\", \"loggedIn\" FROM public.\"User\" WHERE login = '" + txtLogin.Text + "' and password = '" + GetMD5(txtPassword.Text) + "'";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                var reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    MyUser = new User((int)reader.GetValue(0), reader.GetValue(1).ToString(), (byte[])reader.GetValue(2), (int)reader.GetValue(3));
                    reader.Close();

                    string req = "update public.\"User\" set \"loggedIn\" = '" + 1 + "' where \"idUser\" = '" + MyUser.IdUser + "'";
                    NpgsqlCommand cmdLoggedIn = new NpgsqlCommand(req, cnx);
                    cmdLoggedIn.ExecuteNonQuery();

                    cnx.Close();
                    lblError.Visible = false;
                    lblWorked.Visible = true;
                    ChatRoom chatRoom = new ChatRoom();
                    this.Hide();
                    chatRoom.Show();
                }
                else
                {
                    lblError.Visible = true;
                    reader.Close();
                    cnx.Close();
                    return;
                }
            }
            catch (NpgsqlException ex)
            {
                Console.Write(ex.Message);
                cnx.Close();
                //lblError.Text = ex.Message;
                lblError.Visible = true;
            }
        }

        public static String GetMD5(String Texte)
        {
            String md5Hash = "";
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(Texte);
            data = x.ComputeHash(data);
            md5Hash = Encoding.ASCII.GetString(data);
            return md5Hash;
        }

        private void linkInscription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cnx.Close();
            this.Hide();
            Inscription inscription = new Inscription();
            inscription.Show();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }
    }
}
