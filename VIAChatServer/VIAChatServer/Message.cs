using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatServer
{
    class Message
    {
        public String Body { get; private set; }
        public User Author { get; private set; }

        public Message(String body, User author)
        {
            Body = body;
            Author = author;
        }

        public Message(User author)
        {
            Body = "";
            Author = author;
        }

        public void Append(Char character) //Append a character to the message's body
        {
            Body += character;
        }
    }
}
