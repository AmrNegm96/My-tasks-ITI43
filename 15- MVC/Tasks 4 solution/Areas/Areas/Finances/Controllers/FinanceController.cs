using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Areas.Areas.Finances.Controllers
{
    [HandleError(View = "myErrorPage")]
    // i can make many error pages for each type of exception 
    public class FinanceController : Controller
    {
        
        public ActionResult TestFun1()
        {
            string msg = null;
            ViewBag.msgLength = msg.Length; // error
            return View();
        }

        public ActionResult TestFun2()
        {
            string msg = null;
            ViewBag.msgLength = msg.Length; // error
            return View();
        }
        [HandleError(View = "myErrorPage2")]
        public ActionResult TestFun3()
        {
            string msg = null;
            ViewBag.msgLength = msg.Length; // error
            return View();
        }
        // GET: Finances/Finance
        public ActionResult Index()
        {
            return View();
        }

        // GET: Finances/Finance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Finances/Finance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Finances/Finance/Create
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

        // GET: Finances/Finance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Finances/Finance/Edit/5
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

        // GET: Finances/Finance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Finances/Finance/Delete/5
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
