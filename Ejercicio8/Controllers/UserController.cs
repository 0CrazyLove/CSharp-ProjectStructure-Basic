using Ejercicio8.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio8;

public class UserController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid)
        {
            return View("Sucess", user);
        }
        return View();
    }
    
}