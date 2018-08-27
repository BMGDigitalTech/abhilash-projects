using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersApp.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            ViewBag.SysTime = DateTime.Now.ToString();
            try
            {
                List<string> countries = new List<string>() { "India", "USA", "UK" };
                ViewBag.CountryName = countries[2];
                return View();
            }
            catch (Exception)
            {
                return View("error");
            }
            
        }

        public IActionResult countries()
        {
            List<string> mycountries = new List<string>() { "India", "USA", "UK" };
            ViewBag.countries = mycountries[3];
            return View();
        }

        //protected override void OnException(ExceptionContext filtercontext)
        //{
        //    base.OnException(filtercontext);
        //    filtercontext.ExceptionHandled = true;
        //    filtercontext.Controller.ViewBag.Message = filtercontext.Exception.Message;
        //    filtercontext.Result = View("Error");
        //}

        public IActionResult GetPhotoGallery()
        {
            List<string> myimages = new List<string>() { "~/img/1.png", "~/img/2.jpg", "~/img/3.png", "~/img/4.jpg", "~/img/5.png" };
            ViewBag.myimages = myimages;
            return PartialView("PhotoGallery");
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [ActionName("Contact")]
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Square()
        {
            ViewBag.Result = Multiply(10, 10);
            return View();
        }

        public IActionResult Cube()
        {
            ViewBag.Result = Multiply(Multiply(10, 10), 10);
            return View();
        }

        [NonAction]
        public int Multiply(int a, int b)
        {
            int c = a * b;
            return c;
        }
    }
}