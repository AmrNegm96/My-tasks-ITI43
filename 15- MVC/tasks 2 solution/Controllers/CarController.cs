using Carstask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carstask.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getAll()
        {
            List<Car> carsList = CarList.cars;

            ViewBag.myCars = carsList;

            return View();
        }
        public ActionResult getById(int id)
        {
            ViewBag.selectedCar = CarList.cars.FirstOrDefault(c => c.Num == id);
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewBag.selectedCar = CarList.cars.FirstOrDefault(c => c.Num == id);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, string color, string model, string manfacture)
        {
            Car editedCar = CarList.cars.FirstOrDefault(c=>c.Num == id);
            editedCar.Color = color;
            editedCar.Model = model;
            editedCar.Manfacture = manfacture;
            return RedirectToAction("getAll");
        }
        public ActionResult delete(int id)
        {
            Car deletedCar = CarList.cars.FirstOrDefault(c=>c.Num ==id);
            CarList.cars.Remove(deletedCar);
            return RedirectToAction("getAll");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int id, string color, string model, string manfacture)
        {
            Car car = new Car();

            car.Num = id;
            car.Color = color;
            car.Model = model;
            car.Manfacture = manfacture;

            CarList.cars.Add(car);

            return RedirectToAction("getAll");
        }
    }
}