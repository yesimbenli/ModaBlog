using System.Web;
using System.Web.Optimization;

namespace ModaBlog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/jquery.min.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/slick.min.js",
                      "~/Scripts/jquery.waypoints.min.js",
                      "~/Scripts/jquery.easing.1.3.js",
                      "~/Scripts/main.js",
                      "~/Scripts/respond.js"));
      
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/css/_icon-fonts.css",
                      "~/Content/css/helpers.css",
                      "~/Content/css/landing-1.css",
                      "~/Content/css/landing-2.css",
                      "~/Content/css/restaurant.css",
                      "~/Content/css/slick-theme.css",
                      "~/Content/css/slick.css",
                      "~/Content/css/style.css",
                      "~/Content/css/bootstrap/bootstrap.css",
                      "~/Content/fonts/ionicons/css/ionicons.min.css",
                      "~/Content/fonts/law-icons/font/flaticon.css",
                      "~/Content/fonts/fontawesome/css/font-awesome.min.css",
                      "~/Content/css/slick.css",
                      "~/Content/css/slick-theme.css",
                      "~/Content/css/helpers.css",
                      "~/Content/css/style.css",
                      "~/Content/site.css"
                      ));
                
        }
    }
}
