using ProductsCategoryMVC.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductsCategoryMVC.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext context = new NorthwindContext();
        public ActionResult helperPage()
        {
            ViewBag.Products = context.Products.ToList();
            return View();
        }
        //Post: Product/categoryid
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View(context.Products.ToList());
        }
        //Post: Product/categoryid

        [HttpPost]
        public ActionResult Index(int CategoryID)
        {
            List<Product> prds = context.Products.Where(p=>p.CategoryID== CategoryID).ToList();
            ViewBag.Categories = context.Categories.ToList();
            return View(prds);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var selected = context.Products.FirstOrDefault(p => p.ProductID == id);
            return View(selected);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.Categories = context.Categories.ToList();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Product prd = new Product();

                prd.ProductName = collection["ProductName"];
                prd.SupplierID = int.Parse(collection["SupplierID"]);
                prd.CategoryID = int.Parse(collection["CategoryID"]);
                prd.QuantityPerUnit = collection["QuantityPerUnit"];
                prd.UnitPrice = int.Parse(collection["UnitPrice"]);
                prd.UnitsInStock = Convert.ToInt16(collection["UnitsInStock"]);
                prd.UnitsOnOrder = Convert.ToInt16(collection["UnitsOnOrder"]);
                prd.ReorderLevel = Convert.ToInt16(collection["ReorderLevel"]);
                prd.Discontinued = Convert.ToBoolean(collection["Discontinued"]); 

                context.Products.Add(prd);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            Product prd = context.Products.Find(id);
            ViewBag.Category = context.Categories.ToList();
            return View(prd);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Product prd = context.Products.Find(id);
                prd.ProductName = collection["ProductName"];
                prd.CategoryID = int.Parse(collection["CategoryID"]);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /* POST: Product/Edit/5
         * public ActionResult Edit(int id, Product Prd)
        //{
        //    try
        //    {
        //        Product product = context.Products.Find(id);
        //        product.ProductName = Prd.ProductName;
        //        product.CategoryID = Prd.CategoryID;
        //        context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}*/

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var deletedProduct = context.Products.Find(id);
            context.Products.Remove(deletedProduct);
            
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        //// POST: Product/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
