using Ejercicio14.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio14.Controllers
{
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
                return View("Account", user);
            }
            return View(user);
        }
    }
}
