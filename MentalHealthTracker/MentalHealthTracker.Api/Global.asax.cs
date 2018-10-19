using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Http' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Http;
#pragma warning restore CS0234 // The type or namespace name 'Http' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Mvc;
#pragma warning restore CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'Optimization' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Optimization;
#pragma warning restore CS0234 // The type or namespace name 'Optimization' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Routing;

namespace MentalHealthTracker.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
