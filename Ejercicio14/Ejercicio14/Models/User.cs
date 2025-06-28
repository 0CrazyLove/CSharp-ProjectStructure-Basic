using Ejercicio14.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio14.Models
{
    public class User
    {
        [ValidName] 
        public string? Name { get; set; }
        [ValidAge]
        public string? Age { get; set; }

    }
}
