using AdapterDesignPattern.Adapter;
using AdapterDesignPattern.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AdapterDesignPattern.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public async Task<string> GetMessage()
        {
            var newMessageService = new OldMessageService();
            var withAdapter = new OldMessageAdapter(newMessageService);
            var withoutAdapter = new NewMessageService();
            return $"Message Received from Legacy Message Service : {await withAdapter.GetMessage()}\nMessage Received from New Message Service : {await withoutAdapter.GetMessage()}";
        }
    }
}
