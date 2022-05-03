using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEstudiantes.Views.UserControls
{
    public partial class RegistroDocente : UserControl
    {
        public RegistroDocente()
        {
            InitializeComponent();
            this.CbPerfil.DataSource = Controllers.Controller.ObtenerControl().ObtenerPerfiles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Controllers.Controller.ObtenerControl().CreaDocente(txtNombre.Text, txtApellido.Text, mtxtCedula.Text, mtxtTelefono.Text, CbPerfil.SelectedIndex);
            Form FormActual = FindForm();
            FormActual.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = FindForm();
            form.Close();
        }
    }
}
