using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppDNF
{
    public class Controller2Controller:Controller
    {
        public string Action4()
        {
            return "Products ";
        }

        public string Action5()
        {
            return "Services ";

        }

        public string Action6()
        {
            return "Offers ";
        }
    }
}