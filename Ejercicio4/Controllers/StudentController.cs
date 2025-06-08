using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio4.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {

            return View("Detail", student);
        }
        public IActionResult Detail(Student student)
        {
            return View(student);
        }
    }
}