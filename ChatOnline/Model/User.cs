using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatOnline.Model
{
    public class User
    {
        public static NpgsqlConnection cnx = new NpgsqlConnection("Server=localhost; Port=5432;User Id=postgres; Password=hafsa; Database=ChatOnline");
        public int IdUser { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public byte[] Photo { get; set; }
        public int LoggedIn { get; set; }

        public User(int IdUser, String Login, String Email, byte[] Photo, int LoggedIn)
        {
            this.IdUser = IdUser;
            this.Login = Login;
            this.Email = Email;
            this.Photo = Photo;
            this.LoggedIn = LoggedIn;
        }

        public User(int IdUser, String Login, byte[] photo, int LoggedIn)
        {
            this.IdUser = IdUser;
            this.Login = Login;
            this.Photo = photo;
            this.LoggedIn = LoggedIn;
        }

        public User(int IdUser, String Login)
        {
            this.IdUser = IdUser;
            this.Login = Login;
        }

        public static User GetUserById(int Id)
        {
            cnx.Open();
            String req = "SELECT \"idUser\", \"login\", \"imgUser\", \"loggedIn\" FROM public.\"User\" WHERE \"idUser\" = '" + Id + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(req, cnx);
            var reader = cmd.ExecuteReader();
            reader.Read();
            User MyUser = new User((int)reader.GetValue(0), reader.GetValue(1).ToString(), (byte[])reader.GetValue(2), (int)reader.GetValue(3));
            reader.Close();
            cnx.Close();
            return MyUser;
        }
    }
}
