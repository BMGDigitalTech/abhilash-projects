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

        public IActionResult UserDetail()
        {
            User u1 = new User();
            u1.firstname = "Abhilash";
            u1.lastname = "N";
            u1.email = "abhi@example.com";
            return View(u1);
        }

        public IActionResult Users()
        {
            List<User> u = new List<User>()
            {
                new User() {firstname="Abhilash", lastname="N", email="abhi@example.com"},
                new User() {firstname="Abhishek", lastname="Kulkarni", email="rambo@example.com"},
                new User() {firstname="Arjun", lastname="V", email="arjun@example.com"},
                new User() {firstname="Chetan", lastname="Gadad", email="chetan@example.com"}
            };
            return View(u);
        }

        public IActionResult Combined()
        {
            List<User> u = new List<User>()
            {
                new User() {firstname="Abhilash", lastname="N", email="abhi@example.com"},
                new User() {firstname="Abhishek", lastname="Kulkarni", email="rambo@example.com"},
                new User() {firstname="Arjun", lastname="V", email="arjun@example.com"},
                new User() {firstname="Chetan", lastname="Gadad", email="chetan@example.com"}
            };

            List<Product> p = new List<Product>()
            {
                new Product() { ProductId=101,ProductName="PS4",Cost=30000},
                new Product() { ProductId=102,ProductName="Mobile",Cost=15000},
                new Product() {ProductId=103, ProductName="Washing Machine", Cost=18000}
            };

            ViewModel vm = new ViewModel();
            vm.u = u;
            vm.p = p;


            return View(vm);
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
