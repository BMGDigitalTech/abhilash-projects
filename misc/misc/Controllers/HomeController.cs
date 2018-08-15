﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using misc.Models;

namespace misc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
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

        public JsonResult JsonData()
        {
            Fruit[] fruits = new Fruit[]
            {
                new Fruit {ID = 1, Name = "Bananas", Price = 1.50M},
                new Fruit {ID = 2, Name = "Grapes", Price = 1.10M},
                new Fruit {ID = 3, Name = "Mangoes", Price = 2.50M},
            };

            return Json(fruits);
        }
    }
}
