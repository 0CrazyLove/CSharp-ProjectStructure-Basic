using System.ComponentModel.DataAnnotations;
namespace Ejercicio10.Models;

public class ProductViewModel
{
    [Required(ErrorMessage = "Nombre del campo requerido.")]
    [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Longitud no valida.")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Precio del campo requerido.")]
    [Range(typeof(decimal), "1000", "1000000")]
    public decimal? Price { get; set; }
    [Required(ErrorMessage = "Codigo del campo requerido.")]
    [RegularExpression(@"^\d{6}$", ErrorMessage = "debe de contener exactamente 6 digitos")]
    public string? Code { get; set; }
    [Required(ErrorMessage = "Gmail del campo requerido.")]
    [EmailAddress(ErrorMessage = "Emial debe de ser valido")]
    public string? SupplierEmail { get; set; }
}