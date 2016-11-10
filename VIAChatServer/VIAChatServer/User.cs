using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIAChatServer
{
    public class User
    {
        private String name { get; }

        public User(String userName)
        {
            name = userName;
        }
    }
}
