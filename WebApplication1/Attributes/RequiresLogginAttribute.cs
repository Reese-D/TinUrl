using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Attributes
{
    public class RequiresLogginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = HttpContext.Current.Session;
            if (session["User"] == null)
            {
                filterContext.Result =  
                    new RedirectResult($"/Account/Login?targetUrl={filterContext.HttpContext.Request.Url.AbsolutePath}");
            }
        }
    }
}