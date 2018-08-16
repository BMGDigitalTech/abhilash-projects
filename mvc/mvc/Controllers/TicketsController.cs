using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Index()
        {
            Seats s = new Seats() { Location = "Platinum", Price = 300.00M };

            return View(s);
        }
    }
}