
namespace Ejercicios_for
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
            this.btnImprimirNum = new System.Windows.Forms.Button();
            this.btnDigitos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImprimirNum
            // 
            this.btnImprimirNum.Location = new System.Drawing.Point(261, 97);
            this.btnImprimirNum.Name = "btnImprimirNum";
            this.btnImprimirNum.Size = new System.Drawing.Size(102, 23);
            this.btnImprimirNum.TabIndex = 0;
            this.btnImprimirNum.Text = "imprimir numeros";
            this.btnImprimirNum.UseVisualStyleBackColor = true;
            this.btnImprimirNum.Click += new System.EventHandler(this.btnImprimirNum_Click);
            // 
            // btnDigitos
            // 
            this.btnDigitos.Location = new System.Drawing.Point(260, 175);
            this.btnDigitos.Name = "btnDigitos";
            this.btnDigitos.Size = new System.Drawing.Size(103, 23);
            this.btnDigitos.TabIndex = 2;
            this.btnDigitos.Text = "Calcular digitos";
            this.btnDigitos.UseVisualStyleBackColor = true;
            this.btnDigitos.Click += new System.EventHandler(this.btnDigitos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDigitos);
            this.Controls.Add(this.btnImprimirNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimirNum;
        private System.Windows.Forms.Button btnDigitos;
    }
}

