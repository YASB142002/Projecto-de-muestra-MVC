using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEstudiantes.Models
{
    class Materia
    {
        internal int Id { get; set; }
        protected string Nombre_Materia { get; set; }
        protected int Creditos { get; set; }
        protected Docente Maestro { get; set; }
        protected static List<Materia> ListaMateria = new List<Materia>();
        public Materia(string nombre, int credito, Docente profe)
        {
            this.Id = ObtenerId();
            this.Nombre_Materia = nombre;
            this.Creditos = credito;
            this.Maestro = profe;
        }

        /// <summary>
        /// Obtiene un id de manera aleatoria
        /// </summary>
        /// <returns></returns>
        private int ObtenerId()
        {
            Random random = new Random();
            random.Next(0, 999999);
            return Convert.ToInt32(random);
        }

        /// <summary>
        /// Agrega la materia registrada a la lista de materias registradas
        /// </summary>
        /// <param name="clase"></param>
        public static void AgregarMateria(Materia clase)
        {
            ListaMateria.Add(clase);
        }

        /// <summary>
        /// Retorna las materias disponibles registradas
        /// </summary>
        /// <returns></returns>
        public static List<Materia> ObtenerListaMateriaTotal()
        {
            return ListaMateria;
        }
    }
}
