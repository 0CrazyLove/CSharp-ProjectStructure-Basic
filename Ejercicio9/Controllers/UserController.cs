using Ejercicio9.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio9;

public class UserController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Register(UserViewModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }

        return View(model);
    }
    public IActionResult Success()
    {
        return View();
    }

}