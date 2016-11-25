using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatClient.Models
{
    class User
    {

        public int id { get; set; }
        public string username { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }
        public bool toBeRegistered { get; set; }

        public User(string username, string email, string password, bool toBeRegistered)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.toBeRegistered = toBeRegistered;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.toBeRegistered = false;
        }

    }
}
