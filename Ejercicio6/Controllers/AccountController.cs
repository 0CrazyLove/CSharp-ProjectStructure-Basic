using Ejercicio6.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio6.Controllers;

public class AccountController : Controller
{
    // GET: Account
    [HttpGet]
    public IActionResult AccountUsuario()
    {
        return View(new Usuario());
    }
    // POST: Account/Create
    [HttpPost]
    public IActionResult AccountUsuario(Usuario usuario)    
    {
        return View(usuario);
    }


}