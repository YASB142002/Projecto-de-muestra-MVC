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
        internal int Creditos { get; set; }
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
            return new Random().Next(0, 999999);
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
        /// Obtiene la lista de las materias registradas hasta el momento
        /// </summary>
        /// <returns>Materias disponibles registradas en una lista de objetos anonimos</returns>
        public static dynamic ObtenerListaMateriaTotal()
        {
            return ListaMateria.Select(ObjAnonimo => new { Id = ObjAnonimo.Id, Nombre = ObjAnonimo.Nombre_Materia, Creditos = ObjAnonimo.Creditos}).ToList();
        }

        /// <summary>
        /// Obtiene la materia solicitada por el estudiante
        /// </summary>
        /// <param name="id">Id de la materia</param>
        /// <returns>El objeto de tipo materia</returns>
        public static Materia ObtenerMateriaSolicitada(int id)
        {

            return ListaMateria.Find(idmateria => idmateria.Id == id);
        }
    }
}
