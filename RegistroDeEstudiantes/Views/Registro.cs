using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEstudiantes.Views
{
    public partial class FmRegistro : Form
    {
        public FmRegistro()
        {
            InitializeComponent();
            //----------UserControl----------
            this.rgEstudiante = new Tools.RegistroEstudiante(); 
            this.rgDocente = new UserControls.RegistroDocente();
            this.rgMateria = new Tools.RegistroMateria();
            //
            //PnlUserControls
            //
            this.PnlUserControls.Controls.Add(rgEstudiante);
        }

        private void FmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void RbEstudiantes_CheckedChanged(object sender, EventArgs e)
        {
            AddUserControl(rgEstudiante);
        }

        private void RbMateria_CheckedChanged(object sender, EventArgs e)
        {
            AddUserControl(rgMateria);
        }

        private void RbDocentes_CheckedChanged(object sender, EventArgs e)
        {
            AddUserControl(rgDocente);
        }




        /// <summary>
        /// Agrega los UserControls al formulario correspondiente
        /// </summary>
        /// <param name="control"> Control correspondiente para agregar</param>
        private void AddUserControl(UserControl control)
        {
            if (!this.PnlUserControls.Controls.Contains(control))
            {
                this.PnlUserControls.Controls.Clear();
                this.PnlUserControls.Controls.Add(control);
            }
        }

        
        /// <summary>
        /// Control personalizado Registro Docente, realizado para simplificar el registro de los datos de un docente
        /// </summary>
        private UserControls.RegistroDocente rgDocente;
        /// <summary>
        /// Control personalizado Registro Estudiante, realizado para simplificar el registro de los datos de un estudiante
        /// </summary>
        private Tools.RegistroEstudiante rgEstudiante;//Estos dos controles tienen la direccion 'Tools' porque fueron creados en otra carpeta con ese nombre
        /// <summary>
        /// Control personalizado Registro Materia, realizado para simplificar el registro de los datos de una Materia
        /// </summary>
        private Tools.RegistroMateria rgMateria; //Luego se movilizaron a la carpeta 'UserControls' cumplen la misma funcion solo es el cruce de nombres en la direccion donde fue creado su namespace

    }
}
