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

namespace AppWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            Profesor profesor = new Profesor()
            {
                Nombre = Interaction.InputBox("Ingrese Nombre del profesor: "),
                Apellido = Interaction.InputBox("Ingrese Apellido del profesor: "),
                DNI = Interaction.InputBox("Ingrese DNI del profesor: "),
                Titulo = Interaction.InputBox("Ingrese Titulo del profesor: "),
            };
            int filasAfectadas = DacProfesor.insert(profesor);
            if (filasAfectadas > 0)
            {
                gridProfesores.DataSource = DacProfesor.listar();
                MessageBox.Show("Insert Ok");

            }

        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            traerTodosProfesores();
        }
        private void traerTodosProfesores()
        {
            gridProfesores.DataSource = DacProfesor.listar();
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            gridProfesores.DataSource = DacProfesor.traerPorIdDS(id);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Interaction.InputBox("Ingrese ID a modificar: "));
            try
            {
                Profesor profesor = new Profesor()
                {
                    Id = id,
                    Nombre = Interaction.InputBox("Ingrese nombre: ").ToString(),
                    Apellido = Interaction.InputBox("Ingrese apellido: ").ToString(),
                    DNI = Interaction.InputBox("Ingrese dni: ").ToString(),
                    Titulo = Interaction.InputBox("Ingrese titulo: ").ToString(),
                };

                int filasAfcetadas = DacProfesor.update(profesor);
                if (filasAfcetadas > 0)
                {
                    MessageBox.Show("Insert ok");
                    traerTodosProfesores();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Interaction.InputBox("Ingrese ID a eliminar: "));
            try
            {
                int filasAfcetadas = DacProfesor.delete(id);
                if (filasAfcetadas > 0)
                {
                    MessageBox.Show("Delete ok");
                    traerTodosProfesores();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar " + ex.Message);
            }

        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            gridProfesores.DataSource = DacProfesor.traerPorIdDS(id);

        }
    }
}

