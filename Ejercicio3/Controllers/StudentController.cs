using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio3.Controllers;
 
public class StudentController : Controller
{
    //metodo detial
    public IActionResult Detail()
    {
        var student = new Student(2, "fulanito", 310, "porno");
        return View(student);
    }
    
}