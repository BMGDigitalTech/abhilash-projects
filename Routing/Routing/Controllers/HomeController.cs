using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "Index";
            ViewBag.ID = id;
            return View("Result");
        }

        public IActionResult Blog()
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "Blog";
            ViewBag.ID = RouteData.Values["id"];
            return View("Result");
        }

        public IActionResult All()
        {
            ViewBag.Controller = "HomeController";
            ViewBag.Action = "All";
            ViewBag.ID = RouteData.Values["id"];
            ViewBag.All = RouteData.Values["all"];
            return View("Result");
        }


    }
}
