using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio3.Controllers;

public class StudentController : Controller
{
    //metodo detial
    public IActionResult Detial()
    {
        var student = new Student();
        return View();
    }
    
}