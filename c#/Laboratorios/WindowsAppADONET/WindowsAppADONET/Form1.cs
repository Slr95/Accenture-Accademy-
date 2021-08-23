using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Agregar

namespace WindowsAppADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConection_Click(object sender, EventArgs e)
        {
            //Especifica la cadena de conexion
            string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
            //crear objeto de conexion(SqlConnection)
            SqlConnection connection = new SqlConnection(cadena);

            try//para el control de las exceptions - errores
            {
                //aqui el codigo ejecutable
                connection.Open();
            }
            catch (Exception exobj)
            {
                //tratamiento del error, en este caso muestra mensaje de error
                MessageBox.Show("Ocurrio un error - " + exobj.Message);
            }
            //connection.Open();//con esto se abre la conexion
        }
    }
}
