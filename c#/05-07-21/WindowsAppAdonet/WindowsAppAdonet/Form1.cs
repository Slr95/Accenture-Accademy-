using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //agregar

namespace WindowsAppAdonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Especificar la cadena de conexion 
            string cadena = "Data Source=DESKTOP-7S67QET;Initial Catalog=pubs;Integrated Security=True";
            //Crear un objeto de conexion (SqlConnection)
            SqlConnection connection = new SqlConnection(cadena);

            try
            {
                connection.Open();//abrimos la conexion
            }
            //Exception es un generico
            catch (SqlException exobj)
            {

                MessageBox.Show("Ocurrio un error -" + exobj.Message);
            }

            



        }
    }
}
