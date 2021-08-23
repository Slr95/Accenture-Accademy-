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

namespace WindowsDemo
{
    public partial class frmEjemplos : Form
    {
        public frmEjemplos()
        {
            InitializeComponent();
        }

        private void btnPruebaFor_Click(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i <= 2; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese número: "));

                while (numero >= 100)
                {
                    MessageBox.Show("si es mayor a 100. Intente de nuevo....");
                    numero = Convert.ToInt32(Interaction.InputBox("Ingrese número: "));
                }

                //clasica
                //total = total + numero;

                total += numero;
            }

            MessageBox.Show(total.ToString());


        }

        private void btnMetodoFuncion_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(Interaction.InputBox("Ingrese número: "));
            int numero2 = Convert.ToInt32(Interaction.InputBox("Ingrese número: "));

            int result = suma(numero1, numero2);

            MessageBox.Show(result.ToString());

            //llamado a la funcion

            MessageBox.Show(mensaje());

            MessageBox.Show(mensaje("Gaby"));
            MessageBox.Show(mensaje("Juan", "Perez"));
        }

        // creamos una función
        private int suma(int numero1, int numero2)
        {
            return numero1 + numero2;

        }


        private string mensaje()
        {

            return "Bienvenido!";

        }

        private string mensaje(string nombre)
        {

            return "Bienvenido! " + nombre;

        }

        private string mensaje(string nombre, string apellido)
        {

            return "Bienvenido! " + nombre + " " + apellido;

        }

        private void btnTestSwitch_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtdiaSemana.Text);

            switch (numero)
            {
                case 1:
                    MessageBox.Show("Lunes");
                    break;
                case 2:
                    MessageBox.Show("Martes");
                    break;
                case 3:
                    MessageBox.Show("Miercoles");
                    break;
                case 4:
                    MessageBox.Show("Jueves");
                    break;
                case 5:
                    MessageBox.Show("Viernes");
                    break;
                case 6:
                    MessageBox.Show("Sabado");
                    break;
                case 7:
                    MessageBox.Show("Domingo");
                    break;

                default:
                    MessageBox.Show("Los numeros deben estar entre 1 y 7");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(btnOpcionFinanciacion.Text);

            switch(opcion)
            {
                case 1:
                    MessageBox.Show("Te descuento un 10%");
                    break;
                case 2:
                    MessageBox.Show("Te descuento un 10%");
                    break;
                case 3:
                    MessageBox.Show("Te descuento un 10%");
                    break;

                default:
                    MessageBox.Show("No te descuento nada");
                    break;

            }
        }
    }
}
