
namespace slnSistemaLibros
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
            this.btnVerAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerAutor
            // 
            this.btnVerAutor.Location = new System.Drawing.Point(390, 151);
            this.btnVerAutor.Name = "btnVerAutor";
            this.btnVerAutor.Size = new System.Drawing.Size(75, 23);
            this.btnVerAutor.TabIndex = 0;
            this.btnVerAutor.Text = "Ver Autor";
            this.btnVerAutor.UseVisualStyleBackColor = true;
            this.btnVerAutor.Click += new System.EventHandler(this.btnVerAutor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerAutor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerAutor;
    }
}

