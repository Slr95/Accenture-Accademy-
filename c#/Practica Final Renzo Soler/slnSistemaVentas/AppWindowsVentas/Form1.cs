using Datos;
using Datos.Models;
using Microsoft.VisualBasic;
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

namespace AppWindowsVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            Vendedor vendedor = new Vendedor()
            {
                Nombre = Interaction.InputBox("Ingrese Nombre del vendedor: "),
                Apellido = Interaction.InputBox("Ingrese Apellido del vendedor: "),
                DNI = Interaction.InputBox("Ingrese DNI del vendedor: "),
                Comision = Convert.ToDecimal(Interaction.InputBox("Ingrese la comision del vendedor: ")),
            };
            int filasAfectadas = DacVendedor.insert(vendedor);
            if (filasAfectadas > 0)
            {
                gridVendedores.DataSource = DacVendedor.listar();
                MessageBox.Show("Insertado con exito");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Interaction.InputBox("Ingrese ID a modificar: "));
            try
            {
                Vendedor vendedor = new Vendedor()
                {
                    Id = id,
                    Nombre = Interaction.InputBox("Ingrese nombre: ").ToString(),
                    Apellido = Interaction.InputBox("Ingrese apellido: ").ToString(),
                    DNI = Interaction.InputBox("Ingrese dni: ").ToString(),
                    Comision = Convert.ToDecimal(Interaction.InputBox("Ingrese comision: ")),
                };

                int filasAfcetadas = DacVendedor.update(vendedor);
                if (filasAfcetadas > 0)
                {
                    MessageBox.Show("Modificado con exito");
                    traerTodosVendedores();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al modificar " + ex.Message);
            }
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            traerTodosVendedores();
        }

        private void traerTodosVendedores()
        {
            gridVendedores.DataSource = DacVendedor.listar();
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            gridVendedores.DataSource = DacVendedor.traerPorIdDS(id);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Interaction.InputBox("Ingrese ID a eliminar: "));
            try
            {
                int filasAfcetadas = DacVendedor.delete(id);
                if (filasAfcetadas > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    traerTodosVendedores();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar " + ex.Message);
            }
        }
    }
}
