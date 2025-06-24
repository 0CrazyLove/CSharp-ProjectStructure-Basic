using System.ComponentModel.DataAnnotations;

namespace Ejercicio11.Models;

public class UsuarioViewModel
{
    [Required (ErrorMessage = "Campo obligatorio")]
    public string? Nombre { get; set; }
    [MayorDeEdad]
    public int? Edad { get; set; }
}