using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatServer
{
    public class User
    {
        public String Name { get; private set; }

        public User(String userName)
        {
            Name = userName;
        }
    }
}
