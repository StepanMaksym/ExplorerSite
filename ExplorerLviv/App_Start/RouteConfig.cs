﻿using System.Web.Mvc;
using System.Web.Routing;

namespace ExplorerLviv
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //  /Database/Zhovkva
            routes.MapRoute("Database",
                "database/{name}",
                new {controller = "Database", action = "Search", name = UrlParameter.Optional});

            // Parameter defaults
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Database", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}