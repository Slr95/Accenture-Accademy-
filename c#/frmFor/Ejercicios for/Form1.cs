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

namespace Ejercicios_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimirNum_Click(object sender, EventArgs e)
        {
            for ( int numero = 1; numero<=100; numero++)
            {
                MessageBox.Show(numero.ToString());
            }
        }

        private void btnDigitos_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(Interaction.InputBox("Ingresa numero entre 0 y 999"));
            
            while (numero !=0)
            {

                if (numero >= 100)
                {
                    MessageBox.Show("El numero tiene 3 digitos");
                }
                else

                    if (numero >= 10)
                {
                    MessageBox.Show("El numero tiene 2 digitos");
                }
                else
                {
                    MessageBox.Show("El numero tiene 1 digitos");
                }
            }
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {

        }
    }
}
