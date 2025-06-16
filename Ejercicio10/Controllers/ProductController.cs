using Ejercicio10.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio10;

public class ProductController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(ProductViewModel product)
    {
        if (ModelState.IsValid)
        {
            return View("Success" , product);
        }
        return View(product);
    }


}