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

namespace WindowsAppAdonet
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            // 1-crear objeto de conexion 
            string cadena = Properties.Settings.Default.KeyDB;
            SqlConnection connection = new SqlConnection(cadena);

            // 2-crear una variable del tipo cadena para especificar la consulta de sql
            string consultaSQL = "SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]";

            // 3-preparar el SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, connection);

            // 4-declarar un reader

            SqlDataReader reader;

            // 5-abrir conexion
            connection.Open();

            // 6-invocar ExecuteReader() del SqlCommand
            reader = command.ExecuteReader();

            // 7-recorrer los datos
            while (reader.Read())
            {
                lstReader.Items.Add(reader[0].ToString() + " " + 
                    reader["au_lname"].ToString() + " " + 
                    reader["au_fname"].ToString());
            }
            //cerrar reader
            reader.Close();
            //cerrar conexion
            connection.Close(); //IMPORTANTE SIEMPRE CERRAR - OJO!!!
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            gridAuthor.DataSource = DacAuthor.Select_TraerTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city = txtCiudad.Text;

            gridAuthor.DataSource = DacAuthor.Select_PorCiudad(city);
        }

        private void btnCiudadSinDuplicados_Click(object sender, EventArgs e)
        {
            foreach (var city in DacPublisher.Select_CiudadSinDuplicados())
            {
                lstCiudad.Items.Add(city.City);
            }

        }

        private void btnMostrarPublicadores_Click(object sender, EventArgs e)
        {
            gridCiudad.DataSource = DacPublisher.SelectTraerTodos();
        }

        private void btnInsertarAutor_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                Au_id = "172-32-8888"
           ,
                Au_fname = "Albornoz"
           ,
                Au_lname = "Carlos"
           ,
                Phone = "408 496-4444"
           ,
                Address = "San Martin 233"
           ,
                City = "Quilmes"
           ,
                State = "Bs"
           ,
                Zip = "01878"
           ,
                Contract = true
            };

            //insertamos el autor
            int filasAfcetadas = DacAuthor.Insert(author);
            if (filasAfcetadas > 0)
            {
                MessageBox.Show("Insert ok");
            }

        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            TraerTodosAutores();
        }

        private void TraerTodosAutores()
        {
            gridAuthor.DataSource = DacAuthor.Select_TraerTodo();
        }


        private void btnModificarAutor_Click(object sender, EventArgs e)
        {

        }
    }
}
