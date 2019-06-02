﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Products", action = "Index",id=UrlParameter.Optional }
);

routes.MapRoute(
    name: "display",
    url: "{controller}/{action}/{ip}/{port}",
    defaults: new { controller = "Products", action = "display"}
 );

            routes.MapRoute(
    name: "lineDisplay",
    url: "{controller}/{action}/{ip}/{port}/{time}",
    defaults: new { controller = "Products", action = "lineDisplay" }
);

 routes.MapRoute(
name: "save",
url: "{controller}/{action}/{ip}/{port}/{time}/{duration}/{fileName}",
defaults: new { controller = "Products", action = "save" }
);

        }
    }
}
