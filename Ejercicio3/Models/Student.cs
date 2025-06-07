using Ejercicio3.Models;
namespace Ejercicio3.Models;

public class Student
{
    //atributos privados de la clase
    private int id;
    private string? name;
    private int age;
    private string? course;
    //constructor
    public Student()
    {
        Id = id;
        Name = name!;

    }

    //propiedad para id
    public int Id
    {
        get { return id; }
        set
        {
            if (value <= 0)
            {
                System.Console.WriteLine("valor no permitido");
            }
            else
            {
                id = value;
            }
        }
    }
    //propiedad para name
    public string Name
    {
        get { return name!; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                System.Console.WriteLine("valor del nombre no permitido");
            }
            else
            {
                name = value;
            }
        }
    }
}