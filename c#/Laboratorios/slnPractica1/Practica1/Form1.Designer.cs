﻿
namespace Practica1
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
            this.btnIntanciarYMostrarMedico = new System.Windows.Forms.Button();
            this.gridMedico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIntanciarYMostrarMedico
            // 
            this.btnIntanciarYMostrarMedico.Location = new System.Drawing.Point(12, 12);
            this.btnIntanciarYMostrarMedico.Name = "btnIntanciarYMostrarMedico";
            this.btnIntanciarYMostrarMedico.Size = new System.Drawing.Size(42, 29);
            this.btnIntanciarYMostrarMedico.TabIndex = 0;
            this.btnIntanciarYMostrarMedico.Text = "Instanciar Y Mostrar Medico";
            this.btnIntanciarYMostrarMedico.UseVisualStyleBackColor = true;
            this.btnIntanciarYMostrarMedico.Click += new System.EventHandler(this.btnIntanciarYMostrarMedico_Click);
            // 
            // gridMedico
            // 
            this.gridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedico.Location = new System.Drawing.Point(60, 12);
            this.gridMedico.Name = "gridMedico";
            this.gridMedico.Size = new System.Drawing.Size(728, 426);
            this.gridMedico.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridMedico);
            this.Controls.Add(this.btnIntanciarYMostrarMedico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntanciarYMostrarMedico;
        private System.Windows.Forms.DataGridView gridMedico;
    }
}

