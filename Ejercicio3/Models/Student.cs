namespace Ejercicio3.Models;

public class Student
{
    //atributos privados de la clase
    private int id;
    private string? name;
    private int age;
    private string? course;
    //constructor
    public Student(int id, string name, int age, string course)
    {
        Id = id;
        Name = name;
        Age = age;
        Course = course;
    }


    //propiedad para id
    public int Id
    {
        get { return id; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("El ID debe ser mayor que cero.");
            }
            id = value;
        }
    }
    //propiedad para name
    public string? Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El nombre no puede ser nulo o vacío.");
            }


            name = value;

        }
    }
    //propiedad para name
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("La edad debe ser mayor que cero.");
            }

            age = value;

        }
    }
    //propiedad para course
    public string? Course
    {
        get { return course; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El curso no puede ser nulo o vacío.");
            }

            course = value;

        }
    }
}