using System.ComponentModel.DataAnnotations;
namespace Ejercicio8.Models;

public class User
{
    [Required(ErrorMessage = "El nombre no puede ser nulo. BAKA NAYO!! >:c")]
    [StringLength(50, MinimumLength = 3)]
    public string? FullName { get; set; }

    [Required(ErrorMessage = "El email no puede ser nulo...NYA~~~~~ CUMMMM")]
    [EmailAddress(ErrorMessage = "ERROR!!! formato de correo no valido Qwq")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Error, el año ingresado no es valido... V.V ")]
    [Range(18, 100, ErrorMessage = "El rango de la edad no es valdio! *se viene en su boca como castigo >:3")]
    public int? Age { get; set; }

    [Required(ErrorMessage = "Contraseña no valida...(PUTA DE MIERDA)")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "la longitud de la cadenas no es valida(soy gay)")]
    public string? Password { get; set; }
    [Required(ErrorMessage = "Escriba su contraseña correctamente! >n<")]
    [Compare("Password")]

    public string? ConfirmPassword { get; set; }

}