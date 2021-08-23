
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace WindowsAppADONET
{
    public partial class North : Form
    {
        public North()
        {
            InitializeComponent();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            grodNorth.DataSource = DacProducto.Select_Traertodo();
        }

        private void btnFilterCat_Click(object sender, EventArgs e)
        {
            int category = Convert.ToInt32(txtCategory.Text);
            grodNorth.DataSource = DacProducto.Select_Traertodo(category);
        }
    }
}
