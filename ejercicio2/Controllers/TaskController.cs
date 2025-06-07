using Microsoft.AspNetCore.Mvc;
using ejercicio2.Models;
namespace ejercicio2.Controllers
{
    
    public class TaskController : Controller
    {
        public IActionResult Detial()
        {
            //instanciado el objeto del modelo
            var task = new ejercicio2.Models.Task
            {
                id = 2,
                title = "aprendiendo venirme ~nya",
                description = "en la boca de mi papa pwq",
                completed = true
                

            };
            return View("Detial");
        }
        
    }
}
