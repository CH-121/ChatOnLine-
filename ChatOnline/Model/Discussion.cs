using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatOnline.Model
{
    public class Discussion
    {
        public int IdDiscussion { get; set; }
        public String Message { get; set; }
        public DateTime DateDiscussion { get; set; }
        public User User { get; set; }

        public Discussion(int IdDiscussion, String Message, DateTime DateDiscussion, User User)
        {
            this.IdDiscussion = IdDiscussion;
            this.Message = Message;
            this.DateDiscussion = DateDiscussion;
            this.User = User;
        }

        public Discussion(int IdDiscussion, String Message, DateTime DateDiscussion)
        {
            this.IdDiscussion = IdDiscussion;
            this.Message = Message;
            this.DateDiscussion = DateDiscussion;
        }
    }
}
