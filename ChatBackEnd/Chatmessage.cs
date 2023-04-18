using static System.Net.Mime.MediaTypeNames;

namespace ChatBackEnd
{
    public class Chatmessage
    {
        string datamessage;
        string name;
        DateTime sendtime;

        public DateTime Sendtime { get ; set; }
        public string Name { get; set; }
        public string Datamessage { get; set; }

        public Chatmessage(string Datamessage, string Name)
        {
            this.Datamessage = Datamessage;
            this.Name = Name;
            Sendtime = DateTime.Now;
        }
    }
}
