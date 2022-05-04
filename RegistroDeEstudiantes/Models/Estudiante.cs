using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEstudiantes.Models
{
    class Estudiante : Persona
    {
        protected string Carnet { get; set; }
        protected List<Materia> Clases { get; set; }
        protected static readonly List<Estudiante> ListaEstudiantes = new List<Estudiante>();

        public Estudiante (string nombre, string apellido, string cedula, string telefono, string carnet, List<Materia> clases) : base( nombre, apellido, cedula, telefono)
        {
            this.Id = ObtenerId();
            this.Carnet = carnet;
            this.Clases = clases;
        }
        /// <summary>
        /// Retorna la lista  de materias solicitadas por el estudiante en registro
        /// </summary>
        /// <param name="ListaIdsClases"></param>
        /// <returns></returns>
        public static List<Materia> ObtenerMateriasSolicitadas(List<int> ListaIdsClases)
        {
            List<Materia> ListaSolicitada = new List<Materia>();
            ListaIdsClases.ForEach(id =>
            {
                ListaSolicitada.Add(Materia.ObtenerMateriaSolicitada(id));
            });
            return ListaSolicitada;
        }

        /// <summary>
        /// Agrega el estudiante a registrar a la lista de estudiatnes
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public static bool AgregarEstudiantes(Estudiante estudiante)
        {
            ListaEstudiantes.Add(estudiante);
            return true;
        }


        
    }
}
