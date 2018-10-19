using System;
using System.Collections.Generic;
using System.Linq;
#pragma warning disable CS0234 // The type or namespace name 'Http' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Http;
#pragma warning restore CS0234 // The type or namespace name 'Http' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)

namespace MentalHealthTracker.Api
{
    public static class WebApiConfig
    {
#pragma warning disable CS0246 // The type or namespace name 'HttpConfiguration' could not be found (are you missing a using directive or an assembly reference?)
        public static void Register(HttpConfiguration config)
#pragma warning restore CS0246 // The type or namespace name 'HttpConfiguration' could not be found (are you missing a using directive or an assembly reference?)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
