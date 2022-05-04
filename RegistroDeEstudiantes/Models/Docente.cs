using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEstudiantes.Models
{
    /// <summary>
    /// Posibles perfiles que puede llegar a tener un docente
    /// </summary>
    enum Licenciatura
    {
        Matematica,
        Fisica,
        Ciencias_Sociales,
        Filosofia,
        Literatura,
        Ingles,
        Informatica
    }
    public class Docente : Persona
    {
        protected int Perfil { get; set; }
        private static readonly List<string> Licenciaturas = new List<string>();
        protected static List<Docente> ListaDocentes = new List<Docente>() 
        {
            new Docente("Yerik", "Sequeira", "0011408021018V", "88645369", 6){Id = ObtenerId()}
        };

        public Docente(string nombre, string apellido, string cedula, string telefono, int perfil) : base (nombre, apellido, cedula, telefono)
        {
            this.Id = ObtenerId();
            this.Perfil = perfil;
        }

        /// <summary>
        /// Entrega en una lista todas posibles perfiles que puede tener un docente
        /// </summary>
        /// <returns></returns>
        public static List<string> ObtenerPerfiles()
        {
            string[] Numeracion = Enum.GetNames(typeof(Licenciatura));
            foreach (var item in Numeracion)
                Licenciaturas.Add(item.Replace("_", " "));
            return Licenciaturas;
        }

        /// <summary>
        /// Agrega el nuevo registro del docente y lo guarda en una lista de docentes disponibles
        /// </summary>
        /// <param name="Maestro">Objeto a guardar en la lista temporal</param>
        public static void AgregarDocente(Docente Maestro) 
        {
            ListaDocentes.Add(Maestro);
        }

        /// <summary>
        /// Entrega una lista de docentes que se tiene registro hasta el momento
        /// </summary>
        /// <returns>Una lista de objetos anonimos para ser compatible con la propiedad datasource del datagridview</returns>
        public static dynamic ObtenerListaDocentes()
        {
            return ListaDocentes.Select(ObjAnonimo => new { Id = ObjAnonimo.Id, Nombre = ObjAnonimo.Nombre, Apellido = ObjAnonimo.Apellido, Cedula = ObjAnonimo.Cedula, Telefono = ObjAnonimo.Telefono, Perfil = (Licenciatura)ObjAnonimo.Perfil }).ToList();
        }

        /// <summary>
        /// Retorna un objeto de tipo Docente el cual ha sido solicitado en especifico
        /// </summary>
        /// <param name="idDocente"></param>
        /// <returns></returns>
        public static Docente ObtenerDocente(int? idDocente)
        {
            Docente profe = ListaDocentes.Where(id => id.Id == idDocente).First();
            return profe;
        }
    }
}
