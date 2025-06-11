using Ejercicio7.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio7.Models;

public class ProductController : Controller
{
    //Get: /Product/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    //Post: /Product/Create
    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View(product);
    }
    public IActionResult Success()
    {
        return View();
    }
    
}