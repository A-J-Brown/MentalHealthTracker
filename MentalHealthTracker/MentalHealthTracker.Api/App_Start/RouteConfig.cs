using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Mvc;
#pragma warning restore CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Routing;

namespace MentalHealthTracker.Api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
