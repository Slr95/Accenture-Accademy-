using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Ejer1;
using Entidades.Ejer2;
using Datos;


namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntanciarYMostrarMedico_Click(object sender, EventArgs e)
        {
            DatoContacto objDatoContacto = new DatoContacto();
            Paciente objPaciente = new Paciente();

            List<Paciente> ListaPacientes = new List<Paciente>();
            ListaPacientes.Add(objPaciente);

            //int Id, string Nombre, string Apellido, int Matricula, List<Paciente> Pacientes, DatoContacto DatoContacto
            
            Medico medico = new Medico(1,"Marcos", "Rojo",312, ListaPacientes, objDatoContacto);
            //MessageBox.Show
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridMedico.DataSource = AdminMedico.listar();
        }
    }
}
