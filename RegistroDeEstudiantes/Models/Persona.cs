using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEstudiantes.Models
{
    public class Persona
    {
        protected int Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido, Cedula, Telefono;
        

        public Persona(string nombre, string apellido, string cedula, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Telefono = telefono;
        }
        /// <summary>
        /// Obtiene un id de manera aleatoria
        /// </summary>
        /// <returns></returns>
        public static int ObtenerId()
        {
            return new Random().Next(0, 999999);
        }

    }
}
