using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Areas.Admins.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admins/Admin
        public ActionResult TestFun()
        {
            try
            {
                string msg = null;
                ViewBag.msgLength = msg.Length; // error
                return View();
            }
            catch
            {
                return View("Error");
            }
            
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admins/Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admins/Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admins/Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admins/Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admins/Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admins/Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
