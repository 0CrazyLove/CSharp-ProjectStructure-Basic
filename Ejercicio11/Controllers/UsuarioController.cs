using Ejercicio11.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio11;
public class UsuarioController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(UsuarioViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Exito", model);
        }
        return View(model);
        
    }
}