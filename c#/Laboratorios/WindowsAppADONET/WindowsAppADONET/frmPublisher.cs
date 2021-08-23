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
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void BtnTraerPublisher_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = DacPublisher.Select_Traertodo();
        }

        private void btnMostrarCiudad_Click(object sender, EventArgs e)
        {
            foreach (var item in DacPublisher.Select_CiudadSinDuplicados())
            {
                lstCiudad.Items.Add(item.City);

            }

        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            string city = txtCiudad.Text;
            gridPublisher.DataSource = DacPublisher.Select_PorCiudad(city);
        }

        private void btnFiltroCP_Click(object sender, EventArgs e)
        {
            string city1 = txtcity1.Text;
            string country = txtCountry.Text;
            gridPublisher.DataSource = DacPublisher.Select_PorCiudadPais(city1,country);
        }
    }
}
