using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRExample.Hubs;

namespace SignalRExample.Controllers
{
    public class AnnouncementController : Controller
    {
        public AnnouncementController(IHubContext<MessageHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public IHubContext<MessageHub> _hubContext { get; }

        [HttpGet("/announcement")]
        public IActionResult Index()
        {
            return View();
        }   

        [HttpPost("/announcement")]
        public async Task<IActionResult> Post([FromForm] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", message);
            return RedirectToAction("Index");
        }
    }
}