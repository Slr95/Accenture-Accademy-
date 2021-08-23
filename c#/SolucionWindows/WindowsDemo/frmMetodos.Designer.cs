
namespace WindowsDemo
{
    partial class frmMetodos
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
            this.btnTestVoid = new System.Windows.Forms.Button();
            this.btnTestFuncion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnTestRefactorizarMetodo = new System.Windows.Forms.Button();
            this.btnAreaRectangulo = new System.Windows.Forms.Button();
            this.txtTabla = new System.Windows.Forms.Button();
            this.txtNumeroEntero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTestVoid
            // 
            this.btnTestVoid.Location = new System.Drawing.Point(45, 42);
            this.btnTestVoid.Name = "btnTestVoid";
            this.btnTestVoid.Size = new System.Drawing.Size(218, 23);
            this.btnTestVoid.TabIndex = 0;
            this.btnTestVoid.Text = "Test Void";
            this.btnTestVoid.UseVisualStyleBackColor = true;
            this.btnTestVoid.Click += new System.EventHandler(this.btnTestVoid_Click);
            // 
            // btnTestFuncion
            // 
            this.btnTestFuncion.Location = new System.Drawing.Point(45, 111);
            this.btnTestFuncion.Name = "btnTestFuncion";
            this.btnTestFuncion.Size = new System.Drawing.Size(218, 23);
            this.btnTestFuncion.TabIndex = 1;
            this.btnTestFuncion.Text = "Test Funcion";
            this.btnTestFuncion.UseVisualStyleBackColor = true;
            this.btnTestFuncion.Click += new System.EventHandler(this.btnTestFuncion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnTestRefactorizarMetodo
            // 
            this.btnTestRefactorizarMetodo.Location = new System.Drawing.Point(370, 42);
            this.btnTestRefactorizarMetodo.Name = "btnTestRefactorizarMetodo";
            this.btnTestRefactorizarMetodo.Size = new System.Drawing.Size(189, 23);
            this.btnTestRefactorizarMetodo.TabIndex = 3;
            this.btnTestRefactorizarMetodo.Text = "Test Refactorizar a metodo";
            this.btnTestRefactorizarMetodo.UseVisualStyleBackColor = true;
            this.btnTestRefactorizarMetodo.Click += new System.EventHandler(this.btnTestRefactorizarMetodo_Click);
            // 
            // btnAreaRectangulo
            // 
            this.btnAreaRectangulo.Location = new System.Drawing.Point(370, 111);
            this.btnAreaRectangulo.Name = "btnAreaRectangulo";
            this.btnAreaRectangulo.Size = new System.Drawing.Size(75, 23);
            this.btnAreaRectangulo.TabIndex = 4;
            this.btnAreaRectangulo.Text = "Calcular Area de rectangulo";
            this.btnAreaRectangulo.UseVisualStyleBackColor = true;
            this.btnAreaRectangulo.Click += new System.EventHandler(this.btnAreaRectangulo_Click);
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(370, 229);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(75, 23);
            this.txtTabla.TabIndex = 5;
            this.txtTabla.Text = "Mostrar Tabla";
            this.txtTabla.UseVisualStyleBackColor = true;
            this.txtTabla.Click += new System.EventHandler(this.txtTabla_Click);
            // 
            // txtNumeroEntero
            // 
            this.txtNumeroEntero.Location = new System.Drawing.Point(223, 229);
            this.txtNumeroEntero.Name = "txtNumeroEntero";
            this.txtNumeroEntero.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEntero.TabIndex = 6;
            // 
            // frmMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroEntero);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.btnAreaRectangulo);
            this.Controls.Add(this.btnTestRefactorizarMetodo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnTestFuncion);
            this.Controls.Add(this.btnTestVoid);
            this.Name = "frmMetodos";
            this.Text = "frmMetodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestVoid;
        private System.Windows.Forms.Button btnTestFuncion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnTestRefactorizarMetodo;
        private System.Windows.Forms.Button btnAreaRectangulo;
        private System.Windows.Forms.Button txtTabla;
        private System.Windows.Forms.TextBox txtNumeroEntero;
    }
}