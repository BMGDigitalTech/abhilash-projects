using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Controller = "AdminController";
            ViewBag.Action = "Index";
            return View("Result");
        }

        [Route("test/[controller]/someNews")]
        public IActionResult Blog()
        {
            ViewBag.Controller = "AdminController";
            ViewBag.Action = "Blog";
            return View("Result");
        }

        [Route("someRoute")]
        public IActionResult Pages()
        {
            ViewBag.Controller = "AdminController";
            ViewBag.Action = "Pages";
            return View("Result");
        }

        [Route("[controller]/someNews")]
        public IActionResult News()
        {
            ViewBag.Controller = "AdminController";
            ViewBag.Action = "News";
            return View("Result");
        }
    }
}