using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppDNF
{
    public class Controller1Controller:Controller 
    {
        public string Action1(int? productid)
        {
            return "Index Product id is " + productid;
        }

        public string Action2(string  username)
        {
            return "Username is " +username;
        }

        public string Action3()
        {
            return "Conctact ";
        }
    }
}