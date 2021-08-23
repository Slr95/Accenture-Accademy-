using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindowsFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region

        public int[] horas;

        private void validacion()
        {
            int sueldo = Convert.ToInt32(txtSueldo.Text);
            string puesto = txtPuesto.Text.ToUpper();
            string nombre = txtNombre.Text;
            string apellido = txtNombre.Text;

            if (nombre.Length > 2 && apellido.Length > 2 && nombre.Length < 50 && apellido.Length < 50)
            {
                if (sueldo > 0 && (puesto == "SOPORTE TECNICO" || puesto == "DBA" || puesto == "DESARROLLADOR"))
                {
                    MessageBox.Show("Validacion correcta", "Exito");

                }
                else
                {
                    MessageBox.Show("Validacion incorrecta", "Error de validacion");
                }
            }
            else
            {
                MessageBox.Show("El Nombre y Apellido deben ser mayor a 2 y menor a 50 caracteres", "Error de validacion");
            }

        }

        private void ingresar_horas(int horaDia)
        {
            for (int i = 1; i <= 5; i++)
            {
                int ingesroHr = Convert.ToInt32(Interaction.InputBox("ingrese las horas diarias trabajadas de lunes a viernes", "ingreso de horas"));
                horaDia = horaDia + ingesroHr;

            }
            MessageBox.Show("El total de horas trabajadas es: " + horaDia + " horas");
        }

        #endregion

        private void btnValidaciones_Click(object sender, EventArgs e)
        {
            validacion();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string puesto = txtPuesto.Text;

            MessageBox.Show(nombre + apellido + puesto);
        }

        private void btnIngresarHoras_Click(object sender, EventArgs e)
        {
            int horaDia = 0;
            ingresar_horas(horaDia);
        }
    }
    
}
