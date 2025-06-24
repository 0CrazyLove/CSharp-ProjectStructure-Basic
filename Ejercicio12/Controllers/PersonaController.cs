using Ejercicio12.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio12.Controllers;

public class PersonaController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Persona persona)
    {
        if (ModelState.IsValid)
        {
            //sql
            return View("Confirmacion" , persona);

        }
        return View(persona);
    }
    public IActionResult Confirmacion()
    {
        return View();
    }

}