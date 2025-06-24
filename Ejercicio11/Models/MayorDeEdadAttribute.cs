using System.ComponentModel.DataAnnotations;
namespace Ejercicio11.Models;

public class MayorDeEdadAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null && int.TryParse(value.ToString(), out int edad))
        {
            if (edad >= 18)
            {

                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "debe de ser mayor de 18 años");
            }
        }
        return new ValidationResult(ErrorMessage ?? "Edad invalida");
    }

}