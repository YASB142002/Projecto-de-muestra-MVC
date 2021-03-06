using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistroDeEstudiantes.Views.UserControls
{
    public partial class VisualizacionDeOpciones : Form
    {
        internal int? id;
        internal SortedList<int, int> IdsClase = new SortedList<int, int>();
        private bool Valor;

        public VisualizacionDeOpciones(bool valor)
        {
            InitializeComponent();
            this.Valor = valor;
            if (Valor) // True si es registro de materia y false para registro de estudiantes
            {
                //Cuidado con darle a la propiedad datasource una lista de objetos genericos, esta trabaja solo con listas IEnumerable anonimas
                dgvVisualizaconDeDatos.DataSource = Controllers.Controller.ObtenerControl().ObtenerListaDocentes();
                lblClases.Text = "";
                btnQuitarClase.Visible = false;
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
                {
                    this.id = RetornarId;
                    this.Close();
                }
                else
                {
                    int conteocreditos = 0;
                    foreach (var item in IdsClase)
                        conteocreditos += item.Value;

                    if (conteocreditos > 20)
                    {
                        MessageBox.Show("No puede inscribir mas clases. \n\t El maximo de creditos es 20");
                        return;
                    }
                    IdsClase.Add((int)RetornarId, Controllers.Controller.ObtenerControl().ObtenerCreditoMateria((int)RetornarId)); 
                    //System.ArgumentException: 'Ya existe una entrada con la misma clave.'--------------------------------------------------------------------------------------

                    lblClases.Text += dgvVisualizaconDeDatos.Rows[dgvVisualizaconDeDatos.CurrentRow.Index].Cells[1].Value.ToString() + ", ";
                }
            }
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
                    
                    foreach (var item in IdsClase)
                        lblClases.Text += dgvVisualizaconDeDatos.Rows[item.Key].Cells[1].Value.ToString() + ", ";
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
