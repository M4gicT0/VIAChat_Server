using System;

namespace VIAChatClient.Models
{
    public class Response
    {
        public bool success { get; set; }
        public String body { get; set; }

        public Response()
        {
            success = true;
            body = "";
        }
    }
}
