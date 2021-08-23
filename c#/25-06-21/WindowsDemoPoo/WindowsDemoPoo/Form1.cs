using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemoPoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearInstancias_Click(object sender, EventArgs e)
        {
            //1 declarar y crear instancia
            Paciente paciente = new Paciente();

            //usar las propiedades para escribir Nombre, Apellido y NroHistoriaClinica
            //SET de las propiedades
            paciente.Apellido = "Fernandez";
            paciente.Nombre = "Anabel";
            paciente.NroHistoriaClinica = 1254;

            //Leer las propiedades
            MessageBox.Show(paciente.Nombre + " " + paciente.Apellido);

            Paciente paciente1 = new Paciente("Gabriel", "Gonzalez", new DateTime(1975, 06, 02), 2536);

            MessageBox.Show(paciente1.Apellido + " " + paciente1.NroHistoriaClinica.ToString());
        }

        private void btnCrearMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.Nombre = "Jose";
            medico.Apellido = "Fernandez";
            medico.FechaNacimiento = new DateTime(1970, 11, 11);

            Medico medico2 = new Medico();

            medico2.Nombre = "Juana";
            medico2.Apellido = "Lopez";
            medico2.FechaNacimiento = new DateTime(1985, 05, 06);


            MessageBox.Show(medico.Nombre + " " + medico.Apellido + " " + medico.FechaNacimiento);

            MessageBox.Show(medico2.Nombre + " " + medico2.Apellido + " " + medico2.FechaNacimiento);

        }

        private void btnCrearPaciente_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente()
            {
                Nombre = "Pablo",
                Apellido = "Perez",
                NroHistoriaClinica = 1456
            };

            Paciente paciente2 = new Paciente()
            {
                Nombre = "Agustina",
                Apellido = "Aguirrez",
                NroHistoriaClinica = 4879
            };

            MessageBox.Show(paciente.Nombre + " " + paciente.Apellido + " " + paciente.NroHistoriaClinica);

            MessageBox.Show(paciente2.Nombre + " " + paciente2.Apellido + " " + paciente2.NroHistoriaClinica);

        }

        private void btnCrearHabitacion_Click(object sender, EventArgs e)
        {
            //constructor default
            Habitacion habitacion = new Habitacion();
            

            MessageBox.Show(habitacion.Numero.ToString());

            Habitacion habitacion1 = new Habitacion("Libre", 100);

            MessageBox.Show(habitacion1.Numero.ToString());
        }

        private void btnCrearDirector_Click(object sender, EventArgs e)
        {
            Director director = new Director("Walter", "Garcia", Convert.ToDateTime("1976/01/30"), 134212, "Cardiologo");

            MessageBox.Show(director.Nombre + ", " + director.Apellido + " " + director.FechaNacimiento.ToString() + " Nro.Matricula: " + director.Matricula + " Titulo: " + director.Titulo);


        }
    }
}
