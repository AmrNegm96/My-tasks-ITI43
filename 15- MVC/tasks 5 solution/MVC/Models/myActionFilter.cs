using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public class myActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted Log:"
                + "Action: " + filterContext.RouteData.Values["action"] +
                ", Controller: " + filterContext.RouteData.Values["controller"]);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("OnActionExecuting Log:"
            + "Action: " + filterContext.RouteData.Values["action"] +
            ", Controller: " + filterContext.RouteData.Values["controller"]);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("OnResultExcuted Log:"
            +"httpMethod: "+ filterContext.HttpContext.Request.HttpMethod 
            +"Action: " + filterContext.RouteData.Values["action"] +
            ", Controller: " + filterContext.Controller);
        }
    }
}