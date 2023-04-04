using chrisDay2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace chrisDay2.Controllers
{
    public class DepartmentController : Controller
    {
        ItiEntities context =new ItiEntities();
        public IActionResult Index()
        {
            List<Depratment> deptsModel = context.Departements.ToList();
            return View(/*"Index",*/ deptsModel);
        }


        public IActionResult GetStudents(int id) //deptId
        {
            List<Student> students = context.Students.Where(s => s.Id == id).ToList();
            return View("ShowAllStudents", students);
        }
    }
}
