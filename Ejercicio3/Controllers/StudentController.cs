using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio3.Controllers;

public class StudentController : Controller
{
    //metodo detial
    public IActionResult Detail()
    {
        var student = new Student()
        {
            Id = 3,
            Name = "fulanito",
            Age = 44,
            Course = "actor porno"


        };
        return View(student);
    }
    
}