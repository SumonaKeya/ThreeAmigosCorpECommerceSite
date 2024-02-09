using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace MyEcommerceAdmin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Add the custom route for Cart
            RouteTable.Routes.MapRoute(
                name: "Cart",
                url: "Shop/Cart", // Adjust the area if applicable
                defaults: new { controller = "Cart", action = "Index" }
            );
        }
    }
}
