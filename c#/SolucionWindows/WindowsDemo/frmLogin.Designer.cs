
namespace WindowsDemo
{
    partial class frmLogin
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
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtAñosDeAntiguedad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(170, 174);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(100, 20);
            this.txtsueldo.TabIndex = 1;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(72, 174);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 3;
            this.lblNota1.Text = "Nota 1";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(332, 195);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(72, 223);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 6;
            this.lblNota2.Text = "Nota 2";
            // 
            // txtAñosDeAntiguedad
            // 
            this.txtAñosDeAntiguedad.Location = new System.Drawing.Point(170, 223);
            this.txtAñosDeAntiguedad.Name = "txtAñosDeAntiguedad";
            this.txtAñosDeAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.txtAñosDeAntiguedad.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.txtAñosDeAntiguedad);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtsueldo);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtAñosDeAntiguedad;
    }
}