
namespace WindowsDemo
{
    partial class frmVector
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
            this.btnCarga = new System.Windows.Forms.Button();
            this.btnMostrarNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(93, 53);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(75, 23);
            this.btnCarga.TabIndex = 0;
            this.btnCarga.Text = "Carga";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // btnMostrarNombre
            // 
            this.btnMostrarNombre.Location = new System.Drawing.Point(234, 53);
            this.btnMostrarNombre.Name = "btnMostrarNombre";
            this.btnMostrarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarNombre.TabIndex = 1;
            this.btnMostrarNombre.Text = "Mostrar Nombres";
            this.btnMostrarNombre.UseVisualStyleBackColor = true;
            // 
            // frmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarNombre);
            this.Controls.Add(this.btnCarga);
            this.Name = "frmVector";
            this.Text = "frmVector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.Button btnMostrarNombre;
    }
}