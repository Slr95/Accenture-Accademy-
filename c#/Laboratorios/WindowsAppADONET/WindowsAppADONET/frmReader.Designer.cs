
namespace WindowsAppADONET
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
            this.lstReader = new System.Windows.Forms.ListBox();
            this.btnReader = new System.Windows.Forms.Button();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.btnTraerTodos = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnState = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // lstReader
            // 
            this.lstReader.FormattingEnabled = true;
            this.lstReader.ItemHeight = 16;
            this.lstReader.Location = new System.Drawing.Point(30, 58);
            this.lstReader.Name = "lstReader";
            this.lstReader.Size = new System.Drawing.Size(272, 276);
            this.lstReader.TabIndex = 0;
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(84, 12);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(154, 30);
            this.btnReader.TabIndex = 1;
            this.btnReader.Text = "Prueba de reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(379, 107);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.RowHeadersWidth = 51;
            this.gridAuthor.RowTemplate.Height = 24;
            this.gridAuthor.Size = new System.Drawing.Size(376, 309);
            this.gridAuthor.TabIndex = 2;
            // 
            // btnTraerTodos
            // 
            this.btnTraerTodos.Location = new System.Drawing.Point(510, 12);
            this.btnTraerTodos.Name = "btnTraerTodos";
            this.btnTraerTodos.Size = new System.Drawing.Size(154, 30);
            this.btnTraerTodos.TabIndex = 3;
            this.btnTraerTodos.Text = "Traer Autores";
            this.btnTraerTodos.UseVisualStyleBackColor = true;
            this.btnTraerTodos.Click += new System.EventHandler(this.btnTraerTodos_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(392, 79);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(106, 22);
            this.txtState.TabIndex = 4;
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(510, 78);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(132, 23);
            this.btnState.TabIndex = 5;
            this.btnState.Text = "Filtrar por estado";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(896, 71);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert Author";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(896, 138);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(117, 29);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "Modificar";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(896, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnTraerTodos);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnReader);
            this.Controls.Add(this.lstReader);
            this.Name = "frmReader";
            this.Text = "frmReader";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReader;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.Button btnTraerTodos;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnDelete;
    }
}