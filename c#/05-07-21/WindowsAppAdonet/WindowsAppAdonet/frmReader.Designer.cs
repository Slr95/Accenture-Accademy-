
namespace WindowsAppAdonet
{
    partial class frmReader
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
            this.btnReader = new System.Windows.Forms.Button();
            this.lstReader = new System.Windows.Forms.ListBox();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnCiudadSinDuplicados = new System.Windows.Forms.Button();
            this.gridCiudad = new System.Windows.Forms.DataGridView();
            this.btnMostrarPublicadores = new System.Windows.Forms.Button();
            this.lstCiudad = new System.Windows.Forms.ListBox();
            this.btnInsertarAutor = new System.Windows.Forms.Button();
            this.btnModificarAutor = new System.Windows.Forms.Button();
            this.btnBorrarAutor = new System.Windows.Forms.Button();
            this.btnTraerTodosAutores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(12, 189);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(140, 23);
            this.btnReader.TabIndex = 0;
            this.btnReader.Text = "Prueba de Reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // lstReader
            // 
            this.lstReader.FormattingEnabled = true;
            this.lstReader.Location = new System.Drawing.Point(12, 239);
            this.lstReader.Name = "lstReader";
            this.lstReader.Size = new System.Drawing.Size(140, 199);
            this.lstReader.TabIndex = 1;
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(180, 189);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.Size = new System.Drawing.Size(141, 249);
            this.gridAuthor.TabIndex = 2;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(180, 74);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(110, 23);
            this.btnTraerTodos.TabIndex = 3;
            this.btnTraerTodos.Text = "Traer Autores";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar por ciudad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(177, 148);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 20);
            this.txtCiudad.TabIndex = 5;
            // 
            // btnCiudadSinDuplicados
            // 
            this.btnCiudadSinDuplicados.Location = new System.Drawing.Point(336, 45);
            this.btnCiudadSinDuplicados.Name = "btnCiudadSinDuplicados";
            this.btnCiudadSinDuplicados.Size = new System.Drawing.Size(130, 23);
            this.btnCiudadSinDuplicados.TabIndex = 6;
            this.btnCiudadSinDuplicados.Text = "Ciudad sin duplicados";
            this.btnCiudadSinDuplicados.UseVisualStyleBackColor = true;
            this.btnCiudadSinDuplicados.Click += new System.EventHandler(this.btnCiudadSinDuplicados_Click);
            // 
            // gridCiudad
            // 
            this.gridCiudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCiudad.Location = new System.Drawing.Point(336, 238);
            this.gridCiudad.Name = "gridCiudad";
            this.gridCiudad.Size = new System.Drawing.Size(207, 200);
            this.gridCiudad.TabIndex = 7;
            // 
            // btnMostrarPublicadores
            // 
            this.btnMostrarPublicadores.Location = new System.Drawing.Point(336, 196);
            this.btnMostrarPublicadores.Name = "btnMostrarPublicadores";
            this.btnMostrarPublicadores.Size = new System.Drawing.Size(130, 23);
            this.btnMostrarPublicadores.TabIndex = 10;
            this.btnMostrarPublicadores.Text = "Mostrar Publicadores";
            this.btnMostrarPublicadores.UseVisualStyleBackColor = true;
            this.btnMostrarPublicadores.Click += new System.EventHandler(this.btnMostrarPublicadores_Click);
            // 
            // lstCiudad
            // 
            this.lstCiudad.FormattingEnabled = true;
            this.lstCiudad.Location = new System.Drawing.Point(336, 93);
            this.lstCiudad.Name = "lstCiudad";
            this.lstCiudad.Size = new System.Drawing.Size(253, 95);
            this.lstCiudad.TabIndex = 11;
            // 
            // btnInsertarAutor
            // 
            this.btnInsertarAutor.Location = new System.Drawing.Point(13, 25);
            this.btnInsertarAutor.Name = "btnInsertarAutor";
            this.btnInsertarAutor.Size = new System.Drawing.Size(101, 23);
            this.btnInsertarAutor.TabIndex = 12;
            this.btnInsertarAutor.Text = "Insertar autor";
            this.btnInsertarAutor.UseVisualStyleBackColor = true;
            this.btnInsertarAutor.Click += new System.EventHandler(this.btnInsertarAutor_Click);
            // 
            // btnModificarAutor
            // 
            this.btnModificarAutor.Location = new System.Drawing.Point(144, 25);
            this.btnModificarAutor.Name = "btnModificarAutor";
            this.btnModificarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAutor.TabIndex = 13;
            this.btnModificarAutor.Text = "Modificar Autor";
            this.btnModificarAutor.UseVisualStyleBackColor = true;
            this.btnModificarAutor.Click += new System.EventHandler(this.btnModificarAutor_Click);
            // 
            // btnBorrarAutor
            // 
            this.btnBorrarAutor.Location = new System.Drawing.Point(246, 25);
            this.btnBorrarAutor.Name = "btnBorrarAutor";
            this.btnBorrarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarAutor.TabIndex = 14;
            this.btnBorrarAutor.Text = "Borrar Autor";
            this.btnBorrarAutor.UseVisualStyleBackColor = true;
            // 
            // btnTraerTodosAutores
            // 
            this.btnTraerTodosAutores.Location = new System.Drawing.Point(12, 74);
            this.btnTraerTodosAutores.Name = "btnTraerTodosAutores";
            this.btnTraerTodosAutores.Size = new System.Drawing.Size(111, 23);
            this.btnTraerTodosAutores.TabIndex = 15;
            this.btnTraerTodosAutores.Text = "Traer Autores";
            this.btnTraerTodosAutores.UseVisualStyleBackColor = true;
            this.btnTraerTodosAutores.Click += new System.EventHandler(this.btnTraerTodosAutores_Click);
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTraerTodosAutores);
            this.Controls.Add(this.btnBorrarAutor);
            this.Controls.Add(this.btnModificarAutor);
            this.Controls.Add(this.btnInsertarAutor);
            this.Controls.Add(this.lstCiudad);
            this.Controls.Add(this.btnMostrarPublicadores);
            this.Controls.Add(this.gridCiudad);
            this.Controls.Add(this.btnCiudadSinDuplicados);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.lstReader);
            this.Controls.Add(this.btnReader);
            this.Name = "frmReader";
            this.Text = "frmReader";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCiudad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.ListBox lstReader;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnCiudadSinDuplicados;
        private System.Windows.Forms.DataGridView gridCiudad;
        private System.Windows.Forms.Button btnMostrarPublicadores;
        private System.Windows.Forms.ListBox lstCiudad;
        private System.Windows.Forms.Button btnInsertarAutor;
        private System.Windows.Forms.Button btnModificarAutor;
        private System.Windows.Forms.Button btnBorrarAutor;
        private System.Windows.Forms.Button btnTraerTodosAutores;
    }
}