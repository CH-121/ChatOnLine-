using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatOnline
{
    public partial class Inscription : Form
    {
        NpgsqlConnection cnx = new NpgsqlConnection("Server=localhost; Port=5432;User Id=postgres; Password=hafsa; Database=ChatOnline");
        byte[] bytes;// = new byte[0];
        public Inscription()
        {
            InitializeComponent();
            //lblTitle.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(fileDialog.FileName);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, img.RawFormat);
                BinaryReader binaryReader = new BinaryReader(stream);
                bytes = binaryReader.ReadBytes((int)stream.Length);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text))
            {
                lblLoginError.Visible = true;
                return;
            }
            else
                lblLoginError.Visible = false;

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                lblEmailError.Visible = true;
                return;
            }
            else
                lblLoginError.Visible = false;

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                lblPasswordError.Visible = true;
                return;
            }
            else
                lblPasswordError.Visible = false;

            if (String.IsNullOrEmpty(txtPasswordConfirmation.Text) || (txtPasswordConfirmation.Text != txtPassword.Text))
            {
                lblPasswordConfirmationError.Visible = true;
                return;
            }
            else
                lblPasswordConfirmationError.Visible = false;

            /* ----- Insert into DB ----- */
            try
            {
                if (!cnx.State.Equals(ConnectionState.Open))
                    cnx.Open();
                String qry = "insert into public.\"User\" (\"login\", \"email\", \"password\", \"imgUser\") Values ('" + txtLogin.Text + "', '" + txtEmail.Text + "', '" + GetMD5(txtPassword.Text) + "', :image)";
                NpgsqlCommand cmd = new NpgsqlCommand(qry, cnx);
                NpgsqlParameter paramImage = new NpgsqlParameter(":image", NpgsqlTypes.NpgsqlDbType.Bytea);
                paramImage.Value = bytes;
                cmd.Parameters.Add(paramImage);
                cmd.ExecuteNonQuery();
                lblSaved.Visible = true;
                cnx.Close();
                this.Hide();
                Authentication authentication = new Authentication();
                authentication.Show();
            }
            catch (NpgsqlException ex)
            {
                Console.Write(ex.Message);
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

        private void linkAuthentication_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cnx.Close();
            this.Hide();
            Authentication authentication = new Authentication();
            authentication.Show();
        }

        private void lblEmailError_Click(object sender, EventArgs e)
        {

        }
    }
}
