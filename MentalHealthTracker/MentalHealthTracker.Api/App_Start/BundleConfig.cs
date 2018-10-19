using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Optimization' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Optimization;
#pragma warning restore CS0234 // The type or namespace name 'Optimization' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)

namespace MentalHealthTracker.Api
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
#pragma warning disable CS0246 // The type or namespace name 'BundleCollection' could not be found (are you missing a using directive or an assembly reference?)
        public static void RegisterBundles(BundleCollection bundles)
#pragma warning restore CS0246 // The type or namespace name 'BundleCollection' could not be found (are you missing a using directive or an assembly reference?)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
