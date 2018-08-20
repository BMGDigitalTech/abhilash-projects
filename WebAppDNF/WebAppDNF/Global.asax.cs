using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Mvc;

namespace WebAppDNF
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            /* Multiple routing example */
            /*
            System.Web.Routing.RouteTable.Routes.MapRoute("route1", "home", new { controller = "Controller1", action = "Action1" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route2", "about", new { controller = "Controller1", action = "Action2" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route3", "contact", new { controller = "Controller1", action = "Action3" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route4", "products", new { controller = "Controller2", action = "Action4" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route5", "services", new { controller = "Controller2", action = "Action5" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route6", "offers", new { controller = "Controller2", action = "action6" });
            */
            /* Generic routing - use of single route to call all controllers and its action methods*/
            //System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}");

            /* Default Values to Parameters */
            System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}/{productid}", new { controller = "Controller1", action = "Action1", productid = UrlParameter.Optional }, new { productid = @"^[0-9]$" });
            System.Web.Routing.RouteTable.Routes.MapRoute("route2", "{controller}/{action}/abc/{Username}");
        }
    }
}