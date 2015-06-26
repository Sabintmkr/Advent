using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Advent.App_Start;
using Advent.Library;

namespace Advent
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (!Request.RawUrl.ToLower().StartsWith("/admin/setup") && !Config.AdventInstalled)
                Response.Redirect("~/admin/setup");
        }
    }
}