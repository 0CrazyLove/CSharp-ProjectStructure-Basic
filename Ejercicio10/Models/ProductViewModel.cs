using System.ComponentModel.DataAnnotations;
using Ejercicio10.Models;
namespace Ejercicio10.Models;

public class ProductViewModel
{
    [Required(ErrorMessage = "Nombre del campo requerido.")]
    [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Longitud no valida.")]
    private string? Name { get; set; }
    [Required(ErrorMessage = "Precio del campo requerido.")]
    [Range(typeof(decimal), "1000", "1000000")]
    private decimal? Price { get; set; }
    [Required(ErrorMessage = "Codigo del campo requerido.")]
    [RegularExpression(@"^\d{6}$" , ErrorMessage ="debe de contener exactamente 6 digitos")]
    private string? Code { get; set; }
    [Required(ErrorMessage = "Gmail del campo requerido.")]
    [EmailAddress(ErrorMessage = "Emial debe de ser valido")]
        private string? SupplierEmail { get; set; }
}