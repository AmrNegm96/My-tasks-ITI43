using Microsoft.AspNetCore.Mvc;
using mvcCoreFirst.Models;

namespace mvcCoreFirst.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetAll()
        {
            List<Car> Cars = CarList.cars;
            ViewBag.Cars = Cars;
            return View(ViewBag.Cars);
        }
        public IActionResult GetByNum(int id)
        {

            ViewBag.Car = CarList.cars.FirstOrDefault(c => c.Num == id);
            return View(ViewBag.Car);
        }
        public IActionResult Delete(int id)
        {
            var deleted = CarList.cars.FirstOrDefault(c => c.Num == id);
            CarList.cars.Remove(deleted);
            return RedirectToAction("GetAll");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Car = CarList.cars.FirstOrDefault(c => c.Num == id);
            return View(ViewBag.Car);
        }
        [HttpPost]
        public IActionResult Edit(int id, string color, string model, string manufacturer)
        {
            Car car = CarList.cars.FirstOrDefault(a => a.Num == id);
            car.Color = color;
            car.Model = model;
            car.Manufacture = manufacturer;
            return RedirectToAction("GetAll");
        }
        public IActionResult Add()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Add(int id, string color, string model, string manufacturer)
        {
            Car car = new Car();
            car.Num = id;
            car.Color = color;
            car.Model = model;
            car.Manufacture = manufacturer;
            CarList.cars.Add(car);
            return RedirectToAction("GetAll");
        }
    }
}
