using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Ejercicio13.Models;

public class ValidNameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string Name = value.ToString()!;
            if (Regex.IsMatch(Name, @"^[a-zA-Z\s]+$"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "no se permiten caracteres especiales ");
        }
        return new ValidationResult(ErrorMessage ?? "El campo debe de ser obligatorio.");

    }

}
 