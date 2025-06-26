using Microsoft.AspNetCore.Mvc;
namespace Ejercicio13.Models;

public class CreateController : Controller
{
    [HttpGet]
    public IActionResult UserAccount()
    {
        return View();
    }
    [HttpPost]
    public IActionResult UserAccount(User user)
    {
        if (ModelState.IsValid) return View( "AccountSuccessful",user);
        return View();
    }
    
}