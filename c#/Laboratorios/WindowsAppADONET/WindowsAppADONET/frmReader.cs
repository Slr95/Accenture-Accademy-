using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Models;


namespace WindowsAppADONET
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            //1-objeto de conexion
            //string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=True";
            string cadena = Properties.Settings.Default.KeyDB;
            SqlConnection connection = new SqlConnection(cadena);


            //2-Cadena para especificar la consulta de SQL
            string consultaSQL = "SELECT au_id, au_lname ,au_fname ,phone ,address ,city ,state ,zip ,contract FROM dbo.authors";
            //3- preparar el SqlCommand
            SqlCommand command = new SqlCommand(consultaSQL, connection);
            //4-Declarar un reader
            SqlDataReader reader;
            //5- Abrir conexion
            connection.Open();
            //6-Invocar ExecuteReader() del SqlCommand
            reader = command.ExecuteReader();
            //7-Recorrer datos
            while (reader.Read())
            {
                lstReader.Items.Add(reader[0].ToString() + " " + reader["au_lname"].ToString() + " " + reader["au_fname"].ToString());
            }
            //8-Cerrar Reader
            reader.Close();
            //9-Cerrar coneccion
            connection.Close();//IMPORTANTE CIEMPRE CERRAR!!
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            traerTodosAutores();
        }

        private void traerTodosAutores()
        {
            gridAuthor.DataSource = DacAuthor.Select_Traertodo();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            string estado = txtState.Text;
            gridAuthor.DataSource = DacAuthor.Select_TraerPorState(estado);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author()
                {
                    Au_id = "172-32-8890"
           ,
                    Au_fname = "Pint"
           ,
                    Au_lname = "Agustina"
           ,
                    Phone = "408 222-7777"
           ,
                    Address = "Calle 55"
           ,
                    City = "La Plata"
           ,
                    State = "Bs"
           ,
                    Zip = "01878"
           ,
                    Contract = true

                };
                int filasAfectadas = DacAuthor.insert(author);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Insert ok");
                    traerTodosAutores();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar " + ex.Message);

            }

        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Au_id = "172-32-8890"//id para condición de busqueda
           ,
                Au_fname = "Pint"
           ,
                Au_lname = "Maria Agustina"
           ,
                Phone = "408 222-7777"
           ,
                Address = "Av San Martin 33"
           ,
                City = "Quilmes"
           ,
                State = "Bs"
           ,
                Zip = "01878"
           ,
                Contract = true
            };


            int filasAfcetadas = DacAuthor.update(author);
            if (filasAfcetadas > 0)
            {
                MessageBox.Show("Update ok");
                traerTodosAutores();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string au_id = "172-32-8890";

            int filasAfcetadas = DacAuthor.delete(au_id);
            if (filasAfcetadas > 0)
            {
                MessageBox.Show("Delete ok");
                traerTodosAutores();
            }

        }
    }
}
