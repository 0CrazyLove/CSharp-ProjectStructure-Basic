using Ejercicio5.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio5.Controllers;

public class BookController : Controller
{
    //metodo para mostrar el formulario 
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    //metodo para recibir los datos del formulario
    [HttpPost]
    public IActionResult Create(Book book)
    {
        return View("Detail", book);
    }

    //metodo para mostrar los detalles del libro
    public IActionResult Detail(Book book)
    {
        return View(book);
    }


}