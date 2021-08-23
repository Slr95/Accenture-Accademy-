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
using Datos.Models;

namespace WindowsAppAdonet
{
    public partial class frmDesconectado : Form
    {
        public frmDesconectado()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            gridAutores.DataSource = DacAuthor.Select_TraerTodosDS();
        }

        private void btnTraerPorID_Click(object sender, EventArgs e)
        {
            string au_id = txtId.Text;

            gridAutores.DataSource = DacAuthor.Select_TraerPorId(au_id);
        }
    }
}
