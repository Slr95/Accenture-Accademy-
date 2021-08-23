using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //agregar namespace

namespace WindowsDemo
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        string nombre = string.Empty;
        string apellido = string.Empty;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);

            //output
            lblMensaje.Text = nombre + ", " + apellido + " " + edad;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nombre + " " + apellido,"Nombre Completo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ciudad = Interaction.InputBox("Ingrese la ciudad en donde vive:");

            MessageBox.Show("Usted vive en " + ciudad);
        }
    }
}
