using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEstudiantes.Controllers
{
    class Controller
    {
        static Controller controller;
        Models.Docente Docente;
        Models.Estudiante Estudiante;
        Models.Materia Materia;
        public Controller()
        {

        }
        /// <summary>
        /// Crea un nuevo objeto para ser utilizado desde la vista para poder acceder a los metodos correspondientes 
        /// </summary>
        /// <returns></returns>
        public static Controller ObtenerControl()
        {
            if (controller == null)
                controller = new Controller();
            return controller;
        }
        /// <summary>
        /// Carga todos los perfiles registrados que puede llegar a tener un maestro
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerPerfiles()
        {
            return Models.Docente.ObtenerPerfiles();
        }



        /// <summary>
        /// Crea un nuevo objeto para el registro de un nuevo maestro 
        /// </summary>
        /// <param name="nombre">Nombre del maestro</param>
        /// <param name="apellido">Apellido del maestro</param>
        /// <param name="cedula">Cedula correspondiente del maestro</param>
        /// <param name="telefono">Numero de telefono del maestro</param>
        /// <param name="perfil">Perfil o estudio profesional del maestro</param>
        /// <returns></returns>
        public void CreaDocente(string nombre, string apellido, string cedula, string telefono, int perfil)
        {
            Models.Docente.AgregarDocente(Docente = new Models.Docente(nombre, apellido, cedula, telefono, perfil));
        }
        /// <summary>
        /// Obtiene una lista actualizada de los nombres de los docentes actuales y disponibles para impartir la asignatura
        /// </summary>
        /// <returns></returns>
        public List<Models.Docente> ObtenerListaDocentes()
        {
            return Docente.ObtenerListaDocentes();
        }



        /// <summary>
        /// Funcion para crear una nueva materia
        /// </summary>
        /// <param name="nombre">Nombre de la asignatura que tendra</param>
        /// <param name="credito">Creditos correspondientes a la asignatura</param>
        /// <param name="IdDocente">IdDocente es el valor numerico con el cual se va a encontrar al docente seleccionado para impartir la clase</param>
        /// <returns></returns>
        public bool CrearMateria(string nombre, int credito, int? IdDocente)
        {
            Models.Materia.AgregarMateria(Materia = new Models.Materia(nombre, credito, Models.Docente.ObtenerDocente(IdDocente)));
            return true;
        }

        /// <summary>
        /// Devuelte a la vista la lista de las materias disponibles registradas
        /// </summary>
        /// <returns></returns>
        public List<Models.Materia> ObtenerListaMateria()
        {
            return Models.Materia.ObtenerListaMateriaTotal();
        }




        /// <summary>
        /// Crea un nuevo registro de tipo estudiante
        /// </summary>
        /// <param name="nombre">Nombre que tendra el estudiante a registrar</param>
        /// <param name="apellido">Apellido que tendra el estudiante</param>
        /// <param name="cedula">Cedula que tendra el estudiante</param>
        /// <param name="telefono">Numero de telefono que tendra el estudiante</param>
        /// <param name="carnet">Numero de carnet que tendra el estudiante</param>
        /// <param name="IdsClases">Lista de Ids de las materias que tendra el estudiante</param>
        /// <returns></returns>
        public bool CrearEstudiante(string nombre, string apellido, string cedula, string telefono, string carnet, List<int> IdsClases)
        {
            Models.Estudiante.AgregarEstudiantes(Estudiante = new Models.Estudiante(nombre, apellido, cedula, telefono, carnet, Models.Estudiante.ObtenerMateriasSolicitadas(IdsClases)));
            return true;
        }


    }
}
