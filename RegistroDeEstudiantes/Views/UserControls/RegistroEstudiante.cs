using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEstudiantes.Views.Tools
{
    public partial class RegistroEstudiante : UserControl
    {
        private List<int> IdsClases = new List<int>();
        public RegistroEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IdsClases.Count != 0)
                Controllers.Controller.ObtenerControl().CrearEstudiante(txtNombre.Text, txtApellido.Text, mtxtCedula.Text, mtxtTelefono.Text, mtxtCarnet.Text, IdsClases);
            //validacion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form FormActual = FindForm();//FindForm hace referencia al formulario donde se encuentra el usercontrol actual
            FormActual.Close();
        }

        private void btnSeleccionClases_Click(object sender, EventArgs e)
        {
            UserControls.VisualizacionDeOpciones FormVisualizador = new UserControls.VisualizacionDeOpciones(false);
            FormVisualizador.Show();
            IdsClases = FormVisualizador.IdsClase;

        }
    }
}
