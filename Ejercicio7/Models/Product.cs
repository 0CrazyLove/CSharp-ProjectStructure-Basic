using System.ComponentModel.DataAnnotations;
namespace Ejercicio7.Models;

public class Product
{
    [Required(ErrorMessage = "El nombre es obligatorio. B~BAKA!!")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0. >:C")]
    public double Price { get; set; }
    public int? Stock { get; set; }
}