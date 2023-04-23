using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using w05.EndPoint.Services;

namespace w05.EndPoint.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class ChatmessageController : ControllerBase
    {
        static List<Chatmessage> messages = new List<Chatmessage>();
        IHubContext<SignalRHub> hub;
        //public ChatmessageController(List<Chatmessage> messages, IHubContext<SignalRHub> hub)
        //{        
        //    this.hub = hub;
        //}
        [HttpPost]       
        public IActionResult AddMessage(Chatmessage message)
        {
            messages.Add(message);
            //this.hub.Clients.All.SendAsync("MessageSent",message);
            return Ok();
        }
        [HttpGet]
        public List<Chatmessage> GetMessages()
        {
            return messages;
        }

    }
}