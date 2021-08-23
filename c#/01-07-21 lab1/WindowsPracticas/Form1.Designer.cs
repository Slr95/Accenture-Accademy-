
namespace WindowsPracticas
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
            this.btnPolimorfismo = new System.Windows.Forms.Button();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPolimorfismo
            // 
            this.btnPolimorfismo.Location = new System.Drawing.Point(331, 103);
            this.btnPolimorfismo.Name = "btnPolimorfismo";
            this.btnPolimorfismo.Size = new System.Drawing.Size(75, 23);
            this.btnPolimorfismo.TabIndex = 0;
            this.btnPolimorfismo.Text = "Polimorfismo";
            this.btnPolimorfismo.UseVisualStyleBackColor = true;
            this.btnPolimorfismo.Click += new System.EventHandler(this.btnPolimorfismo_Click);
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(331, 199);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculo.TabIndex = 1;
            this.btnVehiculo.Text = "Vehiculos";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVehiculo);
            this.Controls.Add(this.btnPolimorfismo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPolimorfismo;
        private System.Windows.Forms.Button btnVehiculo;
    }
}

