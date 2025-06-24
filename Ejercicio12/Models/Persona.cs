using System.ComponentModel.DataAnnotations;
namespace Ejercicio12.Models;

public class Persona
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [SinNumeros]
    public string? Nombre { get; set; }
    [Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120.")]
    [Required(ErrorMessage = "Campo obligatorio.")]
    public int? Edad { get; set; }

}