using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatClient.Models
{
    class Message
    {
        public int id { get; set; }
        public string body { get; private set; }
        public int user_id { get; private set; }

        public Message(string body, int user_id)
        {
            this.body = body;
            this.user_id = user_id;
        }
    }
}
