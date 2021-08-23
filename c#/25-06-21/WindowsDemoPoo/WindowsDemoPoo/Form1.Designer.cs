
namespace WindowsDemoPoo
{
    partial class Form1
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
            this.btnCrearInstancias = new System.Windows.Forms.Button();
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.btnCrearPaciente = new System.Windows.Forms.Button();
            this.btnCrearHabitacion = new System.Windows.Forms.Button();
            this.btnCrearDirector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstancias
            // 
            this.btnCrearInstancias.Location = new System.Drawing.Point(256, 104);
            this.btnCrearInstancias.Name = "btnCrearInstancias";
            this.btnCrearInstancias.Size = new System.Drawing.Size(155, 23);
            this.btnCrearInstancias.TabIndex = 0;
            this.btnCrearInstancias.Text = "Prueba crear pacientes";
            this.btnCrearInstancias.UseVisualStyleBackColor = true;
            this.btnCrearInstancias.Click += new System.EventHandler(this.btnCrearInstancias_Click);
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(256, 155);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(155, 23);
            this.btnCrearMedico.TabIndex = 1;
            this.btnCrearMedico.Text = "Crear Medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Location = new System.Drawing.Point(256, 228);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(155, 23);
            this.btnCrearPaciente.TabIndex = 2;
            this.btnCrearPaciente.Text = "Crear Paciente";
            this.btnCrearPaciente.UseVisualStyleBackColor = true;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnCrearHabitacion
            // 
            this.btnCrearHabitacion.Location = new System.Drawing.Point(256, 303);
            this.btnCrearHabitacion.Name = "btnCrearHabitacion";
            this.btnCrearHabitacion.Size = new System.Drawing.Size(155, 23);
            this.btnCrearHabitacion.TabIndex = 3;
            this.btnCrearHabitacion.Text = "Crear Habitaciones";
            this.btnCrearHabitacion.UseVisualStyleBackColor = true;
            this.btnCrearHabitacion.Click += new System.EventHandler(this.btnCrearHabitacion_Click);
            // 
            // btnCrearDirector
            // 
            this.btnCrearDirector.Location = new System.Drawing.Point(502, 104);
            this.btnCrearDirector.Name = "btnCrearDirector";
            this.btnCrearDirector.Size = new System.Drawing.Size(105, 23);
            this.btnCrearDirector.TabIndex = 4;
            this.btnCrearDirector.Text = "Crear Director";
            this.btnCrearDirector.UseVisualStyleBackColor = true;
            this.btnCrearDirector.Click += new System.EventHandler(this.btnCrearDirector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearDirector);
            this.Controls.Add(this.btnCrearHabitacion);
            this.Controls.Add(this.btnCrearPaciente);
            this.Controls.Add(this.btnCrearMedico);
            this.Controls.Add(this.btnCrearInstancias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstancias;
        private System.Windows.Forms.Button btnCrearMedico;
        private System.Windows.Forms.Button btnCrearPaciente;
        private System.Windows.Forms.Button btnCrearHabitacion;
        private System.Windows.Forms.Button btnCrearDirector;
    }
}

