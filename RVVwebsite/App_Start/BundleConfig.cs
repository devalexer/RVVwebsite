using System.Web;
using System.Web.Optimization;

namespace RVVwebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.js",
                        "~/Scripts/jquery.modal.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/npm.js",
                        "~/assets/js/masonry.js",
                        "~/assets/js/holder.js",
                        "~/assets/js/holder.min.js",
                        "~/assets/js/ie-emulation-modes-warning.js",
                        "~/assets/js/pushy.min.js",
                        "~/assets/js/jquery.magnific-popup.min.js",
                        "~/assets/js/wow.min.js",
                        "~/assets/js/scripts.js",
                        "~/assets/js/odometer.js",
                        "~/assets/js/ie10-viewport-bug-workaround.js",
                        "~/assets/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.css.map",
                      "~/Content/theme.css",
                      "~/Content/site.css",
                      "~/assets/css/masonry.css",
                      "~/Content/jquery.modal.css",
                      "~/assets/css/pushy.css",
                      "~/assets/css/animate.css",
                      "~/assets/css/magnific-popup.css",
                      "~/assets/css/odometer-theme-default.css"));

        }
    }
}
