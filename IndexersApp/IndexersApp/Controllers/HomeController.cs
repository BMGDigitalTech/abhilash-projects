using IndexersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndexersApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
           // Employee emp = new Employee();
           // ViewBag.emp1 = emp[2];


            return View();
        }
    }
}
