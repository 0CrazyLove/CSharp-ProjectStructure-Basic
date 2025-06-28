namespace Ejercicio14.Models.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ValidNameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string name = value.ToString()!;
            if (Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "no se permiten caracteres especiales");
        }
        return new ValidationResult(ErrorMessage ?? "El nombre no puede estar vacío o nulo.");
    }
}
