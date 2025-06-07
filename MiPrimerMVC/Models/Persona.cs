using System;
namespace MiPrimerMVC.Models
{
    public class Persona
    {
        public string? nombre { get; set; }
        public int edad { get; set; }

        //metodo saludar
        public string Greet()
        {
            return "HOLAAAAAAAAAAAAA!!!!!!!!!!!!";
           
        }

    }
}