using Domain.Implementation.Repositories;
using Domain.Implementation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication1.Controllers;

namespace WebApplication1
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
            var serverError = Server.GetLastError() as HttpException;

            if (serverError == null)
                return;
     
            int errorCode = serverError.GetHttpCode();

            if (errorCode != 404)
                return;

            Server.ClearError();
            var helper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            Response.Redirect(helper.Action("custom404","Errors"));
            
            
        }
    }
}
