namespace VIAChatClient.Models
{
    public class User
    {

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int id { get; set; }

        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool toBeRegistered { get; set; }

        public User()
        {
            id = 0;
            username = "";
            email = "";
            password = "";
            toBeRegistered = false;
        }

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
