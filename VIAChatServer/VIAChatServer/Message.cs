using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatServer
{
    class Message
    {
        private String body { get; set; }
        private User author { get; set; }

        public Message(String body, User author)
        {
            this.body = body;
            this.author = author;
        }

        public Message(User author)
        {
            body = "";
            this.author = author;
        }

        public void Append(Char character) //Append a character to the message's body
        {
            body += character;
        }
    }
}
