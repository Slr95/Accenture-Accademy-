using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //agregar

namespace WindowsDemo
{
    public partial class frmMetodos : Form
    {
        public frmMetodos()
        {
            InitializeComponent();
        }

        private void btnTestVoid_Click(object sender, EventArgs e)
        {
            //sobrecarga 1 ()
            imprimir();

            //otro ejemplo
            // string nombre = Interaction.InputBox("Ingrese nombre");

            //sobrecarga 2 - (nombre)
            // imprimir("Gaby");

            imprimir(txtNombre.Text);
        }



        #region metodos

        private void imprimir()
        {
         string nombre = Interaction.InputBox("Ingrese nombre");

            MessageBox.Show("Bienvenido " + nombre);
        }

        private void imprimir(string nombre)
        {

            MessageBox.Show("Bienvenido " + nombre);
        }

        private string imprimir_fn(string nombre)
        {
            string saludo = "Hola " + nombre;
            return saludo;
        }

        private int suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        #endregion

        private void btnTestFuncion_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string resultado = imprimir_fn(nombre);
            MessageBox.Show(resultado);
        }

        private void btnTestRefactorizarMetodo_Click(object sender, EventArgs e)
        {
            int numero1 = 10;
            int numero2 = 22;
            int resultado = 0;
            resultado = suma(numero1, numero2);

            MessageBox.Show(resultado.ToString());
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
          
            int baseR = 10;
            int alturaR = 20;
            int area = baseR * alturaR;

            MessageBox.Show("El area del rectangulo es: " + area);
        }

        private void txtTabla_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumeroEntero.Text);
            multiplicar(numero);
        }

        #region
        private static void multiplicar(int numero)
        {
            for (int i = 0; i < 10; i++)
            {
             //   lstValores.Items.Add(numero * i);
            }
            
        }
        #endregion
    }
}
