using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicUnitTesting.Models;

namespace BasicUnitTesting.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyDbContext _context;

        

        public HomeController(CompanyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Square(int n)
        {
            int sq = n * n;
            ViewBag.sq = sq;
            return View();
        }

        public IActionResult GetEmployee()
        {
            //CompanyDbContext Db = new CompanyDbContext();
            //List<Employee> emps = Db.Employees.ToList();
            List<Employee> emps = _context.Employees.ToList();
            return View(emps);
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
