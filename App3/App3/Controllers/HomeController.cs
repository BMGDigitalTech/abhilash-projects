using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using App3.Models;
using App3.Helpers;

namespace App3.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            //ViewBag.MyEmployee = new Employee() { EmpID = 1, EmpName = "Abhilash", Salary = 60000 };
            Employee emp = new Employee() { EmpID = 1, EmpName = "Abhilash", Salary = 60000 };
            //HttpContext.Session.SetObject("EmpObject", emp);
           // ControllerContext.HttpContext.Application["myemployee"] = emp;
          
            return View();
        }


        public IActionResult employeeDetail()
        {
            //var objComplex = HttpContext.Session.GetObject("EmpObject");

            return View();
        }

        public IActionResult Employees()
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee() {EmpID = 1, EmpName = "Abhilash", Salary = 600000},
                new Employee() {EmpID = 2, EmpName = "Abhishek", Salary = 500000},
                new Employee() {EmpID = 3, EmpName = "Abhijeeth", Salary = 65000},
                new Employee() {EmpID = 4, EmpName = "Abhinav", Salary = 6000},
                new Employee() {EmpID = 5, EmpName = "Basavraj", Salary = 85000},
            };
            ViewBag.EmployeeList = emps;
            return View();
        }

        public IActionResult action1()
        {
            TempData["message"] = "Hello from Tempdata";
            return RedirectToAction("action2", "Home");
        }

        public IActionResult action2()
        {
            ViewBag.msg = Convert.ToString(TempData["message"]);
            
            return View();
        }
    }
}
