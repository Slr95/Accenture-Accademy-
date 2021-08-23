
namespace WindowsAppADONET
{
    partial class frmPublisher
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
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.BtnTraerPublisher = new System.Windows.Forms.Button();
            this.lstCiudad = new System.Windows.Forms.ListBox();
            this.btnMostrarCiudad = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnTraerPorCiudad = new System.Windows.Forms.Button();
            this.txtcity1 = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnFiltroCP = new System.Windows.Forms.Button();
            this.lblciudad2 = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublisher
            // 
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Location = new System.Drawing.Point(44, 146);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.RowHeadersWidth = 51;
            this.gridPublisher.RowTemplate.Height = 24;
            this.gridPublisher.Size = new System.Drawing.Size(429, 267);
            this.gridPublisher.TabIndex = 0;
            // 
            // BtnTraerPublisher
            // 
            this.BtnTraerPublisher.Location = new System.Drawing.Point(57, 3);
            this.BtnTraerPublisher.Name = "BtnTraerPublisher";
            this.BtnTraerPublisher.Size = new System.Drawing.Size(155, 23);
            this.BtnTraerPublisher.TabIndex = 1;
            this.BtnTraerPublisher.Text = "Traer Publisher";
            this.BtnTraerPublisher.UseVisualStyleBackColor = true;
            this.BtnTraerPublisher.Click += new System.EventHandler(this.BtnTraerPublisher_Click);
            // 
            // lstCiudad
            // 
            this.lstCiudad.FormattingEnabled = true;
            this.lstCiudad.ItemHeight = 16;
            this.lstCiudad.Location = new System.Drawing.Point(550, 169);
            this.lstCiudad.Name = "lstCiudad";
            this.lstCiudad.Size = new System.Drawing.Size(155, 244);
            this.lstCiudad.TabIndex = 2;
            // 
            // btnMostrarCiudad
            // 
            this.btnMostrarCiudad.Location = new System.Drawing.Point(550, 118);
            this.btnMostrarCiudad.Name = "btnMostrarCiudad";
            this.btnMostrarCiudad.Size = new System.Drawing.Size(155, 23);
            this.btnMostrarCiudad.TabIndex = 3;
            this.btnMostrarCiudad.Text = "Mostrar Ciudad";
            this.btnMostrarCiudad.UseVisualStyleBackColor = true;
            this.btnMostrarCiudad.Click += new System.EventHandler(this.btnMostrarCiudad_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(57, 69);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 22);
            this.txtCiudad.TabIndex = 4;
            // 
            // btnTraerPorCiudad
            // 
            this.btnTraerPorCiudad.Location = new System.Drawing.Point(187, 68);
            this.btnTraerPorCiudad.Name = "btnTraerPorCiudad";
            this.btnTraerPorCiudad.Size = new System.Drawing.Size(155, 23);
            this.btnTraerPorCiudad.TabIndex = 5;
            this.btnTraerPorCiudad.Text = "Filtrar solo ciudad";
            this.btnTraerPorCiudad.UseVisualStyleBackColor = true;
            this.btnTraerPorCiudad.Click += new System.EventHandler(this.btnTraerPorCiudad_Click);
            // 
            // txtcity1
            // 
            this.txtcity1.Location = new System.Drawing.Point(57, 118);
            this.txtcity1.Name = "txtcity1";
            this.txtcity1.Size = new System.Drawing.Size(100, 22);
            this.txtcity1.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(178, 118);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 22);
            this.txtCountry.TabIndex = 7;
            // 
            // btnFiltroCP
            // 
            this.btnFiltroCP.Location = new System.Drawing.Point(318, 117);
            this.btnFiltroCP.Name = "btnFiltroCP";
            this.btnFiltroCP.Size = new System.Drawing.Size(155, 23);
            this.btnFiltroCP.TabIndex = 8;
            this.btnFiltroCP.Text = "Filtrar ciudad/pais";
            this.btnFiltroCP.UseVisualStyleBackColor = true;
            this.btnFiltroCP.Click += new System.EventHandler(this.btnFiltroCP_Click);
            // 
            // lblciudad2
            // 
            this.lblciudad2.AutoSize = true;
            this.lblciudad2.Location = new System.Drawing.Point(54, 94);
            this.lblciudad2.Name = "lblciudad2";
            this.lblciudad2.Size = new System.Drawing.Size(52, 17);
            this.lblciudad2.TabIndex = 9;
            this.lblciudad2.Text = "Ciudad";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(54, 41);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(52, 17);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(175, 94);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(35, 17);
            this.lblCountry.TabIndex = 11;
            this.lblCountry.Text = "Pais";
            // 
            // frmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 444);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblciudad2);
            this.Controls.Add(this.btnFiltroCP);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtcity1);
            this.Controls.Add(this.btnTraerPorCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.btnMostrarCiudad);
            this.Controls.Add(this.lstCiudad);
            this.Controls.Add(this.BtnTraerPublisher);
            this.Controls.Add(this.gridPublisher);
            this.Name = "frmPublisher";
            this.Text = "frmPublisher";
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.Button BtnTraerPublisher;
        private System.Windows.Forms.ListBox lstCiudad;
        private System.Windows.Forms.Button btnMostrarCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnTraerPorCiudad;
        private System.Windows.Forms.TextBox txtcity1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnFiltroCP;
        private System.Windows.Forms.Label lblciudad2;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCountry;
    }
}