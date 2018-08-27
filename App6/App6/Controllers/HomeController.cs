using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App6.Models;

namespace App6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Register()
        //{
        //    string firstname = Request.Form["firstname"];
        //    string lastname = Request.Form["lastname"];
        //    string email = Request.Form["email"];

        //    string msg = "Firstname " + firstname + "<br />" +
        //                 "Lastname " + lastname + "<br />" +
        //                 "Email " + email + "<br />";

        //    return Content(msg);
        //}

        [HttpPost]
        public IActionResult Register(User u)
        {
           
            string msg = "Firstname " + u.firstname + "<br />" +
                         "Lastname " + u.lastname + "<br />" +
                         "Email " + u.email + "<br />";

            return Content(msg);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
