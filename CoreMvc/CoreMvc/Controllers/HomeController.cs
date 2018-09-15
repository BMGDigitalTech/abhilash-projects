using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace CoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyDbContext _context;

        public HomeController(CompanyDbContext context)
        {
            _context = context;
        }
        [Route("employees/list")]
        public ActionResult Index()
        {
            
            List<Employee> emps = _context.Employees.ToList();
            return View(emps);
        }

        [Route("employees/create")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
      
        
        [Route("employees/create")]
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                _context.Add(emp);
                _context.SaveChanges();
                TempData["message"] = "Employee created";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "There have been errors");
            return View(emp);
        }

        [Route("home/gallery")]
        public IActionResult Gallery()
        {
            return View();
        }
    }
}