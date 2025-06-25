using Microsoft.AspNetCore.Mvc;
using Ejercicio13.Models;
namespace Ejercicio13.Models;

public class CreateController : Controller
{
    [HttpGet]
    public IActionResult UserAccount()
    {
        return View();
    }
    
}