using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FiltersApp.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {

        [Route("Show/{category?}")]
        public IActionResult Index(string category)
        {
            ViewBag.cat = category;
            return View();
        }

        [Route("Search")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}