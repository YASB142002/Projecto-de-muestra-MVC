
namespace RegistroDeEstudiantes
{
    partial class FmVisualizacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtGVDatos = new System.Windows.Forms.DataGridView();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.btnCargarArhivo = new System.Windows.Forms.Button();
            this.CbFiltros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarComo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVDatos
            // 
            this.dtGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVDatos.Location = new System.Drawing.Point(12, 171);
            this.dtGVDatos.Name = "dtGVDatos";
            this.dtGVDatos.Size = new System.Drawing.Size(387, 197);
            this.dtGVDatos.TabIndex = 0;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistro.Location = new System.Drawing.Point(256, 78);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(143, 40);
            this.btnNuevoRegistro.TabIndex = 1;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // btnCargarArhivo
            // 
            this.btnCargarArhivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArhivo.Location = new System.Drawing.Point(12, 12);
            this.btnCargarArhivo.Name = "btnCargarArhivo";
            this.btnCargarArhivo.Size = new System.Drawing.Size(153, 40);
            this.btnCargarArhivo.TabIndex = 2;
            this.btnCargarArhivo.Text = "Cargar Archivo";
            this.btnCargarArhivo.UseVisualStyleBackColor = true;
            // 
            // CbFiltros
            // 
            this.CbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFiltros.FormattingEnabled = true;
            this.CbFiltros.Items.AddRange(new object[] {
            "Total",
            "Estudiantes",
            "Docentes",
            "Materias"});
            this.CbFiltros.Location = new System.Drawing.Point(146, 134);
            this.CbFiltros.Name = "CbFiltros";
            this.CbFiltros.Size = new System.Drawing.Size(111, 26);
            this.CbFiltros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visualizacion: ";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(12, 78);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 40);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(118, 78);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarComo
            // 
            this.btnGuardarComo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarComo.Location = new System.Drawing.Point(171, 12);
            this.btnGuardarComo.Name = "btnGuardarComo";
            this.btnGuardarComo.Size = new System.Drawing.Size(153, 40);
            this.btnGuardarComo.TabIndex = 7;
            this.btnGuardarComo.Text = "Guardar Como";
            this.btnGuardarComo.UseVisualStyleBackColor = true;
            // 
            // FmVisualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 380);
            this.Controls.Add(this.btnGuardarComo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbFiltros);
            this.Controls.Add(this.btnCargarArhivo);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.dtGVDatos);
            this.Name = "FmVisualizacion";
            this.Text = "Visualizacion";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVDatos;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.Button btnCargarArhivo;
        private System.Windows.Forms.ComboBox CbFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardarComo;
    }
}

