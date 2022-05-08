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

        /// <summary>
        /// Funcion para limpiar controladores luego de un nuevo registro
        /// </summary>
        private void LimpiarUserControls()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtCedula.Text = "";
            mtxtTelefono.Text = "";
            mtxtCarnet.Text = "";
            btnSeleccionClases.FlatAppearance.BorderColor = Color.Red;
            IdsClases.Clear();
        }

        /// <summary>
        /// Evalua todos los controladores si cumplen los requerimientos necesarios para el nuevo registro
        /// </summary>
        /// <returns>True = Si alguno no cumple; False = Si todos cumplen</returns>
        public bool ParametersValidation()
        {
            bool valid = false;
            ValidatedTxtBox(txtNombre, valid);
            ValidatedTxtBox(txtApellido, valid);
            ValidatedMaskTxtBox(mtxtCedula, valid);
            ValidatedMaskTxtBox(mtxtTelefono, valid);
            ValidatedMaskTxtBox(mtxtCarnet, valid);
            return valid;
        }


        public bool ValidatedNumericUpDown(NumericUpDown control, bool valid)
        {
            if (!control.Value.Equals(0))
            {
                errorProvider1.SetError(control, "Debe ingresar una edad valida");
            }
            else
                errorProvider1.SetError(control, null);
            if (!valid)//Si la validacion ya es true que no la cambie nunca
                return false;
            else
                return true;
        }

        public bool ValidatedMaskTxtBox(MaskedTextBox control, bool valid)
        {
            if (!control.MaskCompleted)
            {
                errorProvider1.SetError(control, "Debe ingresar un dato valido para el registro");
                return true;
            }
            else
                errorProvider1.SetError(control, null);
            if (!valid)//Si la validacion ya es true que no la cambie nunca
                return false;
            else
                return true;
        }


        /// <summary>
        /// Funcion para validar controlador
        /// </summary>
        /// <param name="control">Control a validar</param>
        /// <param name="valid">Variable auxiliar para detectar si el controlador no cumple los parametros requeridos</param>
        /// <returns>True = No cumple los requisitos; False = Cumple los requisitos</returns>
        public bool ValidatedTxtBox(TextBox control, bool valid)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, "Debe ingresar un dato valido para el registro");
                return valid = true;
            }
            else
                errorProvider1.SetError(control, null);
            if (!valid)//Si la validacion ya es true que no la cambie nunca
                return valid = false;
            else
                return valid = true;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ParametersValidation())
                return;
            else
            {
                if (IdsClases.Count != 0)
                {
                    Controllers.Controller.ObtenerControl().CrearEstudiante(txtNombre.Text, txtApellido.Text, mtxtCedula.Text, mtxtTelefono.Text, mtxtCarnet.Text, IdsClases);
                    errorProvider1.SetError(btnSeleccionClases, "Debe seleccionar una clase como minimo");
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una clase como minimo");
                    errorProvider1.SetError(btnSeleccionClases, null);
                    return;
                }

                LimpiarUserControls();
            }
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
            IdsClases = FormVisualizador.IdsClase.Values.ToList();
            if (IdsClases.Count != 0)
                btnSeleccionClases.FlatAppearance.BorderColor = Color.Green; 
        }
    }
}
