using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace VIAChatServer
{
    
    public class OnlineUsersService : IOnlineUsersService
    {
        public String NumberOfOnlineUsers()
        {
            return "Connected users: " + Server.NbOnlineUsers();
        }
    }
}
