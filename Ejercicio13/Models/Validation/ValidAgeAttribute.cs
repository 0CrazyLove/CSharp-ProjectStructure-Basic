using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Ejercicio13.Models;

public class ValidAgeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value != null)
        {
            int age;
            string input = value.ToString()!;
            bool isValid = int.TryParse(input, out age);
            if (isValid && age >=18 )
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(ErrorMessage ?? "no se permiten menores de edad. ");
        }
        return new ValidationResult(ErrorMessage ?? "El campo debe de ser obligatorio.");

    }

}
 