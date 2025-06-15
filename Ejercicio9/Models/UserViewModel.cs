using System.ComponentModel.DataAnnotations;
namespace Ejercicio9.Models;

public class UserViewModel
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "debe tener entre 3 y 50 caracteres")]
    public string? Name { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Corre invalido")]
    public string? Gmail { get; set; }
    [Required]
    [Range(18, 120, ErrorMessage = "debes tener entre 18 y 120 años")]
    public int Age { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 6)]
    public string? Password { get; set; }
    [Compare("Passoword", ErrorMessage = "Las contraseñas no coinciden")]
    public string? ConfirmPassword { get; set; }

}