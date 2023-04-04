using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Models
{
    public class MyExceptionHandler : HandleErrorAttribute /*FilterAttribute, IExceptionFilter*/
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "myErrorPage",
            };
            base.OnException(filterContext);
        }
    }
}