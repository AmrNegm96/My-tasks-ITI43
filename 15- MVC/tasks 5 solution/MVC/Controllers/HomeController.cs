using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    //[Authorize] // users="none"
    //[AllowAnonymous] // access for all 
    public class HomeController : Controller
    {
        [myActionFilter]
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("myAbout")] //for more security because mvc convection can be detected by hackers
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }
        [NonAction] // msh ha2dar awsalaha 
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}