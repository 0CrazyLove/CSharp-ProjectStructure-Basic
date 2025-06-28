namespace Ejercicio14.Models.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class ValidAgeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            string ageString = value.ToString()!;
            if (int.TryParse(ageString, out int age) && age >= 0 && age <= 120)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "La edad debe ser un número entre 0 y 120.");
        }
        return new ValidationResult(ErrorMessage ?? "La edad no puede estar vacía o nula.");
    }
}


