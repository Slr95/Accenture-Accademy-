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
    public partial class frmVector : Form
    {
        #region metodos

        private string[] nombres; //declaracion de un vector de cadenas 
        private float[] sueldos; //declaracion de un vector de float


        #endregion

        public frmVector()
        {
            InitializeComponent();
        }

        #region metodos

        private void cargar()
        {
            //crear los vectores 
            nombres = new string[5];
            sueldos = new float[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese Nombre: ");
                sueldos[i] = float.Parse(Interaction.InputBox("Ingresar sueldo: "));
            }
        }

        private mostrar
        #endregion

    private void btnCarga_Click(object sender, EventArgs e)
        {

        }
    }
}
