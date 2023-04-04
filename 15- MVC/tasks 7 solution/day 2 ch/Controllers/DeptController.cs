using day_2_ch.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace day_2_ch.Controllers
{
    public class DeptController : Controller
    {
        ItiEntities context = new ItiEntities();
        public IActionResult Index()
        {
            List<Depratment> deptsModel =  context.Departements.ToList();
            return View(/*"Index",*/ deptsModel);
        }

       
        public IActionResult GetStudents(int id) //deptId
        {
            List<Student> students = context.Students.Where(s=>s.Id==id).ToList();
            return View("ShowAllStudents" , students);
        }
    }
}
