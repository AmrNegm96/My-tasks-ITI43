using lec1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace lec1.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public SCCaiContext Context { get; }
        public StudentController(SCCaiContext _Context)
        {
            Context = _Context;
        }
        public ActionResult Index()
        {
            List<Student> stds = Context.Students.ToList();
            return View(stds);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Student stdnt = Context.Students.Find(id);

            if (stdnt == null)
            {
                return NotFound();
            }

            return View(stdnt);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                Context.Students.Add(std);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Student student = Context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Context.Update(student);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = Context.Students.Find(id);
            Context.Students.Remove(student);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
