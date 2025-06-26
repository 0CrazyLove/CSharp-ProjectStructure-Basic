using System.ComponentModel.DataAnnotations;
namespace Ejercicio13.Models;

public class User
{
    [ValidName]
    public string? Name { get; set; }
    [ValidAge]
    public int? Age { get; set; }

}