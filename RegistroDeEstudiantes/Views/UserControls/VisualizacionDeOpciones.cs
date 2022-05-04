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
    public partial class VisualizacionDeOpciones : Form
    {
        internal int? id;
        internal List<int> IdsClase = new List<int>();

        private bool Valor;
        public VisualizacionDeOpciones(bool valor)
        {
            InitializeComponent();
            this.Valor = valor;
            if (Valor)
            {
                //Cuidado con darle a la propiedad datasource una lista de objetos genericos, esta trabaja solo con listas IEnumerable anonimas
                dgvVisualizaconDeDatos.DataSource = Controllers.Controller.ObtenerControl().ObtenerListaDocentes();
                lblClases.Text = "";
            }
            else
                dgvVisualizaconDeDatos.DataSource = Controllers.Controller.ObtenerControl().ObtenerListaMateria();

        }


        /// <summary>
        /// Devuelte el valor de la casilla 0 del datagridview
        /// </summary>
        /// <returns></returns>
        private int? GetId() //El ? indica que puede retornar un valor null
        {
            try
            {
                return int.Parse(dgvVisualizaconDeDatos.Rows[dgvVisualizaconDeDatos.CurrentRow.Index].Cells[0].Value.ToString()); //Retorna el valor de la primera casilla de la fila seleccionada del datagridview; intencionalmente se hizo que al mostrar clases o docente la primera columna fuera la id de cada uno
            }
            catch
            {
                return null;
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int? RetornarId = GetId();
            if (RetornarId != null)
            {
                if (Valor)
                    this.id = RetornarId;
                else
                {
                    IdsClase.Add((int)RetornarId);
                    lblClases.Text += dgvVisualizaconDeDatos.Rows[dgvVisualizaconDeDatos.CurrentRow.Index].Cells[1].Value.ToString() + ", ";
                }
            }
            this.Close();

        }
        private void btnQuitarClase_Click(object sender, EventArgs e)
        {
            int? RetornarId = GetId();
            if (RetornarId != null)
            {
                if (!Valor)
                {
                    IdsClase.Remove((int)RetornarId);

                    lblClases.Text = "Clases Seleccionadas: ";
                    IdsClase.ForEach(id => 
                    {
                        lblClases.Text += dgvVisualizaconDeDatos.Rows[id].Cells[1].Value.ToString() + ", ";
                    });
                    
                }
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisualizacionDeOpciones_Load(object sender, EventArgs e)
        {
            
        }
    }
}
