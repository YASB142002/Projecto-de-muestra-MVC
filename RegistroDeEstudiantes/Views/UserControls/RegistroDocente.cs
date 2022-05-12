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
        private bool valid;
        public RegistroDocente()
        {
            InitializeComponent();
            CbPerfil.DataSource = Controllers.Controller.ObtenerControl().ObtenerPerfiles();
        }

        /// <summary>
        /// Funcion para limpiar controladores luego de un nuevo registro
        /// </summary>
        public void LimpiarUserControls()
        {
            CleanError();
            txtNombre.Text = "";
            txtApellido.Text = "";
            mtxtCedula.Text = "";
            mtxtTelefono.Text = "";
            NudEdad.Value = 0;
        }

        #region Validaciones de los UserControls

        /// <summary>
        /// Evalua todos los controladores si cumplen los requerimientos necesarios para el nuevo registro
        /// </summary>
        /// <returns>True = Si alguno no cumple; False = Si todos cumplen</returns>
        private bool ParametersValidation()
        {
            valid = false;
            valid = ValidatedTxtBox(txtNombre);
            valid = ValidatedTxtBox(txtApellido);
            valid = ValidatedMaskTxtBox(mtxtCedula);
            valid = ValidatedMaskTxtBox(mtxtTelefono);
            valid = ValidatedNumericUpDown(NudEdad);
            return valid;
        }

        /// <summary>
        /// Limpia todos los controles de la marca de error
        /// </summary>
        public void CleanError()
        {
            errorProvider1.SetError(txtNombre, null);
            errorProvider1.SetError(txtApellido, null);
            errorProvider1.SetError(mtxtCedula, null);
            errorProvider1.SetError(mtxtTelefono, null);
            errorProvider1.SetError(NudEdad, null);
        }
        /// <summary>
        /// Sentencia lambda para determinar si la validacion ya es true or false
        /// </summary>
        private Func<bool, bool> KeepError = bol =>
        {
            if (!bol)//Si la validacion ya es true que no la cambie nunca
                return false;
            else
                return true;
        };

        /// <summary>
        /// Funcion para validar NumericUpDown
        /// </summary>
        /// <param name="control">Control a validar</param>
        /// <param name="valid">Variable auxiliar para detectar si el controlador no cumple los parametros requeridos</param>
        /// <returns>True = No cumple los requisitos; False = Cumple los requisitos</returns>
        private bool ValidatedNumericUpDown(NumericUpDown control)
        {
            if (control.Value.Equals(0))
            {
                errorProvider1.SetError(control, "Debe ingresar una edad valida");
                return true;
            }
            else
            {
                errorProvider1.SetError(control, null);
                return KeepError(valid);
            }
        }

        /// <summary>
        /// Funcion para validar MaskTextBox
        /// </summary>
        /// <param name="control">Control a validar</param>
        /// <param name="valid">Variable auxiliar para detectar si el controlador no cumple los parametros requeridos</param>
        /// <returns>True = No cumple los requisitos; False = Cumple los requisitos</returns>
        private bool ValidatedMaskTxtBox(MaskedTextBox control)
        {
            if (!control.MaskCompleted)
            {
                errorProvider1.SetError(control, "Debe ingresar un dato valido para el registro");
                return true;
            }
            else
            {
                errorProvider1.SetError(control, null);
                return KeepError(valid);
            }
        }
        /// <summary>
        /// Funcion para validar TextBox
        /// </summary>
        /// <param name="control">Control a validar</param>
        /// <param name="valid">Variable auxiliar para detectar si el controlador no cumple los parametros requeridos</param>
        /// <returns>True = No cumple los requisitos; False = Cumple los requisitos</returns>
        private bool ValidatedTxtBox(TextBox control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, "Debe ingresar un dato valido para el registro");
                return true;
            }
            else
            {
                errorProvider1.SetError(control, null);
                return KeepError(valid);
            }
        }
        #endregion

        #region Eventos Form
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ParametersValidation())
            {
                Controllers.Controller.ObtenerControl().CreaDocente(txtNombre.Text, txtApellido.Text, mtxtCedula.Text, mtxtTelefono.Text, CbPerfil.SelectedIndex);
                LimpiarUserControls();
            }
            else
                return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = FindForm();
            form.Close();
        }
        #endregion
    }
}
