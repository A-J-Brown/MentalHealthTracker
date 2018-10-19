using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Mvc;
#pragma warning restore CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)

namespace MentalHealthTracker.Api
{
    public class FilterConfig
    {
#pragma warning disable CS0246 // The type or namespace name 'GlobalFilterCollection' could not be found (are you missing a using directive or an assembly reference?)
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
#pragma warning restore CS0246 // The type or namespace name 'GlobalFilterCollection' could not be found (are you missing a using directive or an assembly reference?)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
