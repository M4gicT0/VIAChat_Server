using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VIAChatServer
{
    [ServiceContract]
    public interface IOnlineUsersService
    {
        [OperationContract]
        [WebGet(
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, 
            UriTemplate = "online"
        )]
        String NumberOfOnlineUsers();
    }
}
