namespace VIAChatClient.Models
{
    public class Message
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int id { get; set; }

        public string body { get; private set; }
        public int user_id { get; private set; }

        public Message(string body, int user_id)
        {
            this.body = body;
            this.user_id = user_id;
        }
    }
}
