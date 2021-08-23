
namespace WinAppLibros
{
    partial class frmColecciones
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
            this.btnCrearColeccionAutores = new System.Windows.Forms.Button();
            this.btnCrearListaDeclarativa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearColeccionAutores
            // 
            this.btnCrearColeccionAutores.Location = new System.Drawing.Point(255, 86);
            this.btnCrearColeccionAutores.Name = "btnCrearColeccionAutores";
            this.btnCrearColeccionAutores.Size = new System.Drawing.Size(199, 23);
            this.btnCrearColeccionAutores.TabIndex = 0;
            this.btnCrearColeccionAutores.Text = "Crear lista de autores";
            this.btnCrearColeccionAutores.UseVisualStyleBackColor = true;
            this.btnCrearColeccionAutores.Click += new System.EventHandler(this.btnCrearColeccionAutores_Click);
            // 
            // btnCrearListaDeclarativa
            // 
            this.btnCrearListaDeclarativa.Location = new System.Drawing.Point(255, 190);
            this.btnCrearListaDeclarativa.Name = "btnCrearListaDeclarativa";
            this.btnCrearListaDeclarativa.Size = new System.Drawing.Size(199, 23);
            this.btnCrearListaDeclarativa.TabIndex = 1;
            this.btnCrearListaDeclarativa.Text = "Crear lista con notacion declarativa";
            this.btnCrearListaDeclarativa.UseVisualStyleBackColor = true;
            this.btnCrearListaDeclarativa.Click += new System.EventHandler(this.btnCrearListaDeclarativa_Click);
            // 
            // frmColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearListaDeclarativa);
            this.Controls.Add(this.btnCrearColeccionAutores);
            this.Name = "frmColecciones";
            this.Text = "frmColecciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearColeccionAutores;
        private System.Windows.Forms.Button btnCrearListaDeclarativa;
    }
}