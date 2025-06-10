
namespace Ejercicio6.Models;

    public class Usuario
    {
        // atributos
        private string name = string.Empty;
        private string email = string.Empty;

        // propiedades
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                name = value;

            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El email no puede estar vacío.");
                }
                email = value;

            }
        }



    }
