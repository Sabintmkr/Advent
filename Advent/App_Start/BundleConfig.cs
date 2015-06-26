using System.Web.Optimization;

namespace Advent.App_Start
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts/jquery").Include(
                "~/content/scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts/bootstrap").Include(
                "~/content/scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/design/admin").Include(
                "~/content/design/bootstrap-simplex.css",
                "~/content/design/admin.css"));

            bundles.Add(new StyleBundle("~/bundles/design/main").Include(
                "~/content/design/bootstrap-simplex.css",
                "~/content/design/main.css"));
        }
    }
}