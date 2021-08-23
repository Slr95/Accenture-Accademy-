
namespace WindowsDemo
{
    partial class frmEjemplos
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
            this.btnPruebaFor = new System.Windows.Forms.Button();
            this.btnMetodoFuncion = new System.Windows.Forms.Button();
            this.btnTestSwitch = new System.Windows.Forms.Button();
            this.txtdiaSemana = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpcionFinanciacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPruebaFor
            // 
            this.btnPruebaFor.Location = new System.Drawing.Point(241, 127);
            this.btnPruebaFor.Name = "btnPruebaFor";
            this.btnPruebaFor.Size = new System.Drawing.Size(108, 23);
            this.btnPruebaFor.TabIndex = 0;
            this.btnPruebaFor.Text = "Prueba de for";
            this.btnPruebaFor.UseVisualStyleBackColor = true;
            this.btnPruebaFor.Click += new System.EventHandler(this.btnPruebaFor_Click);
            // 
            // btnMetodoFuncion
            // 
            this.btnMetodoFuncion.Location = new System.Drawing.Point(462, 127);
            this.btnMetodoFuncion.Name = "btnMetodoFuncion";
            this.btnMetodoFuncion.Size = new System.Drawing.Size(143, 23);
            this.btnMetodoFuncion.TabIndex = 1;
            this.btnMetodoFuncion.Text = "Test Metodo Funcion";
            this.btnMetodoFuncion.UseVisualStyleBackColor = true;
            this.btnMetodoFuncion.Click += new System.EventHandler(this.btnMetodoFuncion_Click);
            // 
            // btnTestSwitch
            // 
            this.btnTestSwitch.Location = new System.Drawing.Point(342, 273);
            this.btnTestSwitch.Name = "btnTestSwitch";
            this.btnTestSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnTestSwitch.TabIndex = 2;
            this.btnTestSwitch.Text = "Test Switch";
            this.btnTestSwitch.UseVisualStyleBackColor = true;
            this.btnTestSwitch.Click += new System.EventHandler(this.btnTestSwitch_Click);
            // 
            // txtdiaSemana
            // 
            this.txtdiaSemana.Location = new System.Drawing.Point(342, 216);
            this.txtdiaSemana.Name = "txtdiaSemana";
            this.txtdiaSemana.Size = new System.Drawing.Size(100, 20);
            this.txtdiaSemana.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOpcionFinanciacion
            // 
            this.btnOpcionFinanciacion.Location = new System.Drawing.Point(135, 273);
            this.btnOpcionFinanciacion.Name = "btnOpcionFinanciacion";
            this.btnOpcionFinanciacion.Size = new System.Drawing.Size(75, 23);
            this.btnOpcionFinanciacion.TabIndex = 5;
            this.btnOpcionFinanciacion.Text = "Opcion de Financiacion";
            this.btnOpcionFinanciacion.UseVisualStyleBackColor = true;
            this.btnOpcionFinanciacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmEjemplos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpcionFinanciacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdiaSemana);
            this.Controls.Add(this.btnTestSwitch);
            this.Controls.Add(this.btnMetodoFuncion);
            this.Controls.Add(this.btnPruebaFor);
            this.Name = "frmEjemplos";
            this.Text = "frmEjemplos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPruebaFor;
        private System.Windows.Forms.Button btnMetodoFuncion;
        private System.Windows.Forms.Button btnTestSwitch;
        private System.Windows.Forms.TextBox txtdiaSemana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpcionFinanciacion;
    }
}