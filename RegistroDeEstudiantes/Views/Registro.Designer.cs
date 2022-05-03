
namespace RegistroDeEstudiantes.Views
{
    partial class FmRegistro
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
            this.PnlUserControls = new System.Windows.Forms.FlowLayoutPanel();
            this.GbRadioBnt = new System.Windows.Forms.GroupBox();
            this.RbMateria = new System.Windows.Forms.RadioButton();
            this.RbDocentes = new System.Windows.Forms.RadioButton();
            this.RbEstudiantes = new System.Windows.Forms.RadioButton();
            this.GbRadioBnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUserControls
            // 
            this.PnlUserControls.Location = new System.Drawing.Point(29, 154);
            this.PnlUserControls.Name = "PnlUserControls";
            this.PnlUserControls.Size = new System.Drawing.Size(350, 360);
            this.PnlUserControls.TabIndex = 0;
            // 
            // GbRadioBnt
            // 
            this.GbRadioBnt.Controls.Add(this.RbMateria);
            this.GbRadioBnt.Controls.Add(this.RbDocentes);
            this.GbRadioBnt.Controls.Add(this.RbEstudiantes);
            this.GbRadioBnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRadioBnt.Location = new System.Drawing.Point(29, 19);
            this.GbRadioBnt.Name = "GbRadioBnt";
            this.GbRadioBnt.Size = new System.Drawing.Size(322, 115);
            this.GbRadioBnt.TabIndex = 1;
            this.GbRadioBnt.TabStop = false;
            this.GbRadioBnt.Text = "Tipo de Registro:";
            // 
            // RbMateria
            // 
            this.RbMateria.AutoSize = true;
            this.RbMateria.Location = new System.Drawing.Point(178, 35);
            this.RbMateria.Name = "RbMateria";
            this.RbMateria.Size = new System.Drawing.Size(87, 24);
            this.RbMateria.TabIndex = 2;
            this.RbMateria.Text = "Materia";
            this.RbMateria.UseVisualStyleBackColor = true;
            this.RbMateria.CheckedChanged += new System.EventHandler(this.RbMateria_CheckedChanged);
            // 
            // RbDocentes
            // 
            this.RbDocentes.AutoSize = true;
            this.RbDocentes.Location = new System.Drawing.Point(23, 69);
            this.RbDocentes.Name = "RbDocentes";
            this.RbDocentes.Size = new System.Drawing.Size(104, 24);
            this.RbDocentes.TabIndex = 1;
            this.RbDocentes.Text = "Docentes";
            this.RbDocentes.UseVisualStyleBackColor = true;
            this.RbDocentes.CheckedChanged += new System.EventHandler(this.RbDocentes_CheckedChanged);
            // 
            // RbEstudiantes
            // 
            this.RbEstudiantes.AutoSize = true;
            this.RbEstudiantes.Checked = true;
            this.RbEstudiantes.Location = new System.Drawing.Point(23, 35);
            this.RbEstudiantes.Name = "RbEstudiantes";
            this.RbEstudiantes.Size = new System.Drawing.Size(123, 24);
            this.RbEstudiantes.TabIndex = 0;
            this.RbEstudiantes.TabStop = true;
            this.RbEstudiantes.Text = "Estudiantes";
            this.RbEstudiantes.UseVisualStyleBackColor = true;
            this.RbEstudiantes.CheckedChanged += new System.EventHandler(this.RbEstudiantes_CheckedChanged);
            // 
            // FmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 542);
            this.Controls.Add(this.GbRadioBnt);
            this.Controls.Add(this.PnlUserControls);
            this.Name = "FmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FmRegistro_Load);
            this.GbRadioBnt.ResumeLayout(false);
            this.GbRadioBnt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.FlowLayoutPanel PnlUserControls;
        private System.Windows.Forms.GroupBox GbRadioBnt;
        private System.Windows.Forms.RadioButton RbMateria;
        private System.Windows.Forms.RadioButton RbDocentes;
        private System.Windows.Forms.RadioButton RbEstudiantes;
        
    }
}