
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
        return View();
    }
}
