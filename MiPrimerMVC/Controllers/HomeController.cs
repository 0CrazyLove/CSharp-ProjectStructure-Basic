
using Microsoft.AspNetCore.Mvc;
using MiPrimerMVC.Models;

namespace MiPrimerMVC.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        ViewData["Mensaje"] = "Crazy se esta viniendo en el backend";
        ViewData["pene"] = "probandoooo";
        ViewData["hola"] = "lol";
        return View("Index");
    }

    //nuevo metodo
    public IActionResult Saludo()
    {
        ViewData["Mensaje"] = "HOLA! SOY GAY Y ME GUSTA LA POLLA DE MUJERES TRANSSS THERIAN!!";
        return View("Saludo");

    }

    //nuevo metodo 2
    public IActionResult Fecha()
    {
        ViewData["hora"] = DateTime.Now;
        return View("Fecha");
    }

    //nuevo metodo 3 
    public IActionResult MostrarPersona()
    {
        Persona persona = new Persona
        {
            nombre = "fulanito123",
            edad = 2
        };
        persona.Greet();
        return View(persona);
    }
}
