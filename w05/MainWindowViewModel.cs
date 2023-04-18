using ChatBackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace w05
{
    internal class MainWindowViewModel
    {
        public RestCollection<Chatmessage> Messages { get; set; }

        public ICommand SendMessageCommand { get; set; }
        public MainWindowViewModel()
        {
            Messages = new RestCollection<Chatmessage>("https://localhost:7233/","message");
        }
    }
}
