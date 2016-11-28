namespace VIAChatClient.Models
{
    public class Message
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int id { get; set; }

        public string body { get; set; }
        public int user_id { get; set; }

        public Message(string body)
        {
            this.id = 0;
            this.body = body;
            this.user_id = 0;
        }

        public Message()
        {
            id = 0;
            body = "";
            user_id = 0;
        }
    }
}
