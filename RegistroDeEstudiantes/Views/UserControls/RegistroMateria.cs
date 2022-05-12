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

        public void LimpiarUserControls()
        {
            txtNombre.Text = "";
            NudCreditos.Value = 0;
            this.id = null;
            btnSeleccionDocente.FlatAppearance.BorderColor = Color.Red;
        }

        #region Validaciones de los UserControls

        /// <summary>
        /// Evalua todos los controladores si cumplen los requerimientos necesarios para el nuevo registro
        /// </summary>
        /// <returns>True = Si alguno no cumple; False = Si todos cumplen</returns>
        private bool ParametersValidation()
        {
            bool valid = false;
            ValidatedTxtBox(txtNombre, valid);
            ValidatedNumericUpDown(NudCreditos, valid);
            return valid;
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
        private bool ValidatedNumericUpDown(NumericUpDown control, bool valid)
        {
            if (control.Value.Equals(0))
            {
                errorProvider1.SetError(control, "Debe ingresar una edad valida");
                return true;
            }
            else
                errorProvider1.SetError(control, null);
            return KeepError(valid);
        }

        /// <summary>
        /// Funcion para validar TextBox
        /// </summary>
        /// <param name="control">Control a validar</param>
        /// <param name="valid">Variable auxiliar para detectar si el controlador no cumple los parametros requeridos</param>
        /// <returns>True = No cumple los requisitos; False = Cumple los requisitos</returns>
        private bool ValidatedTxtBox(TextBox control, bool valid)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, "Debe ingresar un dato valido para el registro");
                return valid = true;
            }
            else
                errorProvider1.SetError(control, null);
            return KeepError(valid);
        }

        #endregion

        #region Eventos Form

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ParametersValidation())
            {
                if (id != null)
                {
                    errorProvider1.SetError(btnSeleccionDocente, null);
                    Controllers.Controller.ObtenerControl().CrearMateria(txtNombre.Text, (int)NudCreditos.Value, id);//Id corresponde al id del docente que impartira la clase
                    LimpiarUserControls();
                }
                else
                {
                    errorProvider1.SetError(btnSeleccionDocente, "Debe seleccionar un docente para impartir la clase");
                    return;
                }
            }
            else
                return;
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
            if (!(id == null))
                btnSeleccionDocente.FlatAppearance.BorderColor = Color.Green;
        }
        #endregion
    }
}
