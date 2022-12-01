using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TakeHome
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            if(exception != null)
            {
                int errorStatusCode = 0;

                if (exception is HttpException httpException)
                {
                    errorStatusCode = httpException.GetHttpCode();
                }

                // Adjust the errorPath if the status code is in the 400 series. Otherwise, stick with the default.
                if (errorStatusCode.ToString().StartsWith("4"))
                {
                    var errorPath = "~/Error/NotFound";
                    // Rewrite the request URL to invoke the ErrorController
                    Response.TrySkipIisCustomErrors = true;
                    Response.Clear();
                    Server.ClearError();

                    Server.TransferRequest(errorPath, false);
                }
            }
                    
        }
    }
}
