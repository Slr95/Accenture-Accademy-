
namespace WindowsAppADONET
{
    partial class North
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
            this.grodNorth = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnFilterCat = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lbltext1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grodNorth)).BeginInit();
            this.SuspendLayout();
            // 
            // grodNorth
            // 
            this.grodNorth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grodNorth.Location = new System.Drawing.Point(34, 155);
            this.grodNorth.Name = "grodNorth";
            this.grodNorth.RowHeadersWidth = 51;
            this.grodNorth.RowTemplate.Height = 24;
            this.grodNorth.Size = new System.Drawing.Size(737, 269);
            this.grodNorth.TabIndex = 0;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(83, 106);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(119, 23);
            this.btnShowData.TabIndex = 1;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnFilterCat
            // 
            this.btnFilterCat.Location = new System.Drawing.Point(301, 106);
            this.btnFilterCat.Name = "btnFilterCat";
            this.btnFilterCat.Size = new System.Drawing.Size(160, 24);
            this.btnFilterCat.TabIndex = 2;
            this.btnFilterCat.Text = "Category Search";
            this.btnFilterCat.UseVisualStyleBackColor = true;
            this.btnFilterCat.Click += new System.EventHandler(this.btnFilterCat_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(301, 78);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(100, 22);
            this.txtCategory.TabIndex = 3;
            // 
            // lbltext1
            // 
            this.lbltext1.AutoSize = true;
            this.lbltext1.Location = new System.Drawing.Point(303, 52);
            this.lbltext1.Name = "lbltext1";
            this.lbltext1.Size = new System.Drawing.Size(130, 21);
            this.lbltext1.TabIndex = 4;
            this.lbltext1.Text = "Insert Category";
            // 
            // North
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltext1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnFilterCat);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.grodNorth);
            this.Name = "North";
            this.Text = "North";
            ((System.ComponentModel.ISupportInitialize)(this.grodNorth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grodNorth;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnFilterCat;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lbltext1;
    }
}