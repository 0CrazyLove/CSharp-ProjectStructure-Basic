using System;
namespace ejercicio2.Models
{
    public class Task
    {
        //atributos de la clase
        public int id { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public bool completed { get; set; }

    }
}