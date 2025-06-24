using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Ejercicio12.Models;

public class SinNumerosAttribute : ValidationAttribute
{

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string texto = value.ToString()!;
            if (Regex.IsMatch(texto, @"\d"))
            {
                return new ValidationResult(ErrorMessage ?? "El campo no debe contener números.");
            }
            return ValidationResult.Success;
        }
        return new ValidationResult(ErrorMessage ?? "El campo es obligatorio");
    }

}