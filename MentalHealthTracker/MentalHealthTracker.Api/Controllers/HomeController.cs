using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Mvc;
#pragma warning restore CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)

namespace MentalHealthTracker.Api.Controllers
{
#pragma warning disable CS0246 // The type or namespace name 'Controller' could not be found (are you missing a using directive or an assembly reference?)
    public class HomeController : Controller
#pragma warning restore CS0246 // The type or namespace name 'Controller' could not be found (are you missing a using directive or an assembly reference?)
    {
#pragma warning disable CS0246 // The type or namespace name 'ActionResult' could not be found (are you missing a using directive or an assembly reference?)
        public ActionResult Index()
#pragma warning restore CS0246 // The type or namespace name 'ActionResult' could not be found (are you missing a using directive or an assembly reference?)
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
