using ImageTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageTask.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult ShowDetails(int id , string name , string imageNumber)
        {
            Image img = new Image() { Id=id,Name=name,imageUrl=imageNumber+".jpg"};
            ViewBag.Image = img;
            return View();
        }
    }
}