using System;

namespace VIAChatServer.Models
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

        public Response(bool success, String body)
        {
            this.success = success;
            this.body = body;
        }
    }
}
