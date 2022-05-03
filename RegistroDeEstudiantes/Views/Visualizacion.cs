
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeEstudiantes
{
    public partial class FmVisualizacion : Form
    {
        public FmVisualizacion()
        {
            InitializeComponent();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Views.FmRegistro FmRegistro = new Views.FmRegistro();
            FmRegistro.ShowDialog();
        }
    }
}
