using LibPracticaPolimorfismo.InstrumentosMusicales;
using LibPracticaPolimorfismo.Transportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPracticas;

namespace WindowsPracticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPolimorfismo_Click(object sender, EventArgs e)
        {
            Violin violin = new Violin("Cuerdas");
            Piano piano = new Piano("Teclas");
            Guitarra guitarra = new Guitarra("Cuerdas");

            MessageBox.Show(violin.Afinar());
            MessageBox.Show(violin.Afinar());
            MessageBox.Show(violin.Afinar());
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Auto auto1 = new Auto(14.4f, 4, 88.8f, "Fiat 600");
            Avion avion1 = new Avion(45f, 33, 187f, 241f, 7);

            MessageBox.Show(auto1.acelerar(), "Metodo acelerar");
            MessageBox.Show(avion1.acelerar(), "Metodo acelerar");
            MessageBox.Show($"{auto1.Velocidad}", "Velocidad Auto");
            MessageBox.Show($"{avion1.Velocidad}", "Velocidad Auto");
        }
    }
}
