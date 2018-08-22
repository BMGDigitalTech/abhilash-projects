using App4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["message"] = "Hello From Index";

            
           return RedirectToAction("action2","Home");
        }

        public ActionResult action2()
        {
            ViewBag.x = Convert.ToString(TempData["message"]);
            
            return View();
        }

        public ActionResult action3()
        {
            ViewBag.msg = Convert.ToString(TempData["message"]);
            return View();
        }

        public ActionResult sessionCreate()
        {
            Session["message"] = "Hello From Session";
            return View();
        }

        public ActionResult sessionGet()
        {
            ViewBag.s = Convert.ToString(Session["message"]);
            return View();
        }

        //public ActionResult createCache()
        //{
        //    Employee emp = new Employee() { EmpID = 1, EmpName = "Abhilash", EmpSalary = 600000 };
        //    ControllerContext.HttpContext.Cache.Insert("myemployee", emp, null, DateTime.Now.AddMinutes(5), TimeSpan.Zero);
        //    return View();
        //}

        //public ActionResult viewCache()
        //{
        //    Employee emp2 = (Employee)ControllerContext.HttpContext.Cache["myemployee"];
        //    ViewBag.emp2 = emp2;
        //    return View();
        //}
    }
}