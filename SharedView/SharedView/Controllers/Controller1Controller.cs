using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SharedView.Controllers
{
    public class Controller1Controller : Controller
    {
        public IActionResult Contact()
        {
            ViewBag.location = "Bengalore";
            return View();
        }
    }
}