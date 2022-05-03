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
    public partial class RegistroMateria : UserControl
    {
        private int? id;
        public RegistroMateria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != null)
                Controllers.Controller.ObtenerControl().CrearMateria(txtNombre.Text, (int)NudCreditos.Value, id);//Id corresponde al id del docente que impartira la clase
            //validacion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form FormActual = FindForm();//FindForm hace referencia al formulario donde se encuentra el usercontrol actual
            FormActual.Close();
        }

        private void btnSeleccionDocente_Click(object sender, EventArgs e)
        {
            UserControls.VisualizacionDeOpciones FormVisualizador = new UserControls.VisualizacionDeOpciones(true);
            FormVisualizador.ShowDialog();
            id = FormVisualizador.id;

        }
    }
}
