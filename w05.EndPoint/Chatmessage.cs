namespace w05.EndPoint
{
    public class Chatmessage
    {
        string datamessage;
        string name;
        string sendtime;

        public string Sendtime { get; set; }
        public string Name { get; set; }
        public string Datamessage { get; set; }

        public Chatmessage(string Name, string Datamessage)
        {
            this.Datamessage = Datamessage;
            this.Name = Name;
            this.Sendtime = DateTime.Now.ToString();
        }

        public Chatmessage()
        {
        }
    }
}