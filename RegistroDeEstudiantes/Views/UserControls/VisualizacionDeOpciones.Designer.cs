
namespace RegistroDeEstudiantes.Views.UserControls
{
    partial class VisualizacionDeOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVisualizaconDeDatos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblClases = new System.Windows.Forms.Label();
            this.btnQuitarClase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaconDeDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisualizaconDeDatos
            // 
            this.dgvVisualizaconDeDatos.AllowUserToAddRows = false;
            this.dgvVisualizaconDeDatos.AllowUserToDeleteRows = false;
            this.dgvVisualizaconDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizaconDeDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvVisualizaconDeDatos.Name = "dgvVisualizaconDeDatos";
            this.dgvVisualizaconDeDatos.ReadOnly = true;
            this.dgvVisualizaconDeDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisualizaconDeDatos.Size = new System.Drawing.Size(521, 243);
            this.dgvVisualizaconDeDatos.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(436, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 44);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 265);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 44);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblClases
            // 
            this.lblClases.AutoSize = true;
            this.lblClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClases.Location = new System.Drawing.Point(12, 328);
            this.lblClases.Name = "lblClases";
            this.lblClases.Size = new System.Drawing.Size(150, 16);
            this.lblClases.TabIndex = 15;
            this.lblClases.Text = "Clases Seleccionadas: ";
            // 
            // btnQuitarClase
            // 
            this.btnQuitarClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarClase.Location = new System.Drawing.Point(130, 265);
            this.btnQuitarClase.Name = "btnQuitarClase";
            this.btnQuitarClase.Size = new System.Drawing.Size(115, 44);
            this.btnQuitarClase.TabIndex = 16;
            this.btnQuitarClase.Text = "Quitar clase";
            this.btnQuitarClase.UseVisualStyleBackColor = true;
            this.btnQuitarClase.Click += new System.EventHandler(this.btnQuitarClase_Click);
            // 
            // VisualizacionDeOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 362);
            this.Controls.Add(this.btnQuitarClase);
            this.Controls.Add(this.lblClases);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvVisualizaconDeDatos);
            this.Name = "VisualizacionDeOpciones";
            this.Text = "VisualizacionDeOpciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaconDeDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisualizaconDeDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblClases;
        private System.Windows.Forms.Button btnQuitarClase;
    }
}