using Microsoft.AspNetCore.Mvc;

namespace ChatBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatmessageController : ControllerBase
    {
        private static List<Chatmessage> messages = new List<Chatmessage>();

        [HttpPost]
        public IActionResult AddMessage(Chatmessage message)
        {
            messages.Add(message);
            return Ok();
        }
        [HttpGet]
        public List<Chatmessage> GetMessages()
        {
            return messages;
        }

    }
}
