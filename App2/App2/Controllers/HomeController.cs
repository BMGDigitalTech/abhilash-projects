using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            string s = "";
            s += "Url: " + Request.Url + "<br />";
            s += "Path: " + Request.Path + "<br />";
            s += "Physical Application path: " + Request.PhysicalApplicationPath + "<br />";
            s += "Http Method: " + Request.HttpMethod + "<br />";
            s += "Browse Type: " + Request.Browser.Type + "<br />";
            s += "Query String: " + Request.QueryString + "<br />";
            s += "Headers: " + Request.Headers["User-Agent"] + "<br />";
            return s;
        }

        public void response()
        {
            string s = "<h1>Hello Abhilash</h1>";
            Response.ContentType = "text/html";
            Response.Headers.Add("x", "100");
            Response.StatusCode = 200;
            Response.Write(s);
        }

        public void factorial(int n)
        {
            Response.Write(findFact(n));
        }

        public int findFact(int n)
        {
            int num = n;

            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * findFact(num - 1);
            }
        }

        public ContentResult cresult()
        {
            return new ContentResult() { Content = "Hello World", ContentType = "text/plain" };
        }

        public FileResult learnjavascript() 
        {
            return File("~/JavaScript-Unlocked.pdf", "application/pdf");
        }
    }
}