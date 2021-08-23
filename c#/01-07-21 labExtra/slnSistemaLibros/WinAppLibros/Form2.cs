using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor("Juan ", "Perez ", new DateTime(1978,05,20), "Cordoba 123", "Capital", " Argentina");
            MessageBox.Show("Autor: " + autor.Nombre + "" + autor.Apellido + "" + autor.Pais+""+autor.FechaNacimiento);
        }
    }
}
