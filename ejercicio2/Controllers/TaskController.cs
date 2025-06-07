using Microsoft.AspNetCore.Mvc;
using ejercicio2.Models;
namespace ejercicio2.Controllers
{
    public class TaskController : Controllers
    {
        public IActionResult Detail()
        {
            return View();
        }
        
    }
}