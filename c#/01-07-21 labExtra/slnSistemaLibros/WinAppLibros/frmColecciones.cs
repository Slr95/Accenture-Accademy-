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
using WinAppLibros;

namespace WinAppLibros
{
    public partial class frmColecciones : Form
    {
        public frmColecciones()
        {
            InitializeComponent();
        }

        private void btnCrearColeccionAutores_Click(object sender, EventArgs e)
        {
            //CREAR UNA LISTA DE AUTORES
            //declaracion y creacion de una instancia de la clase List (colecciones autores)
            List<Autor> listaAutores = new List<Autor>();

            //creamos un autor
            Autor autor = new Autor("Jorge", "La plata", new DateTime(1899, 08, 24), "Argentina", "Borges", "calle 2");

            //agregar a la lista
            listaAutores.Add(autor);

            //agregar autor a la lista directamente
            listaAutores.Add(new Autor("Raul", "Alfoncin", new DateTime(1899, 08, 24), "Argentina", "Borges", "calle 2"));
        }

        private void btnCrearListaDeclarativa_Click(object sender, EventArgs e)
        {
            List<Autor> listaAutores = new List<Autor>()
            {
                new Autor("Jorge", "La plata", new DateTime(1899, 08, 24), "Argentina", "Borges", "calle 2"),
                new Autor("Raul", "Alfoncin", new DateTime(1899, 08, 24), "Argentina", "Borges", "calle 2"),
                new Autor("Juanito", "Arcoiris", new DateTime(1899, 08, 24), "Argentina", "Borges", "calle 2")
        };
        }
    }
}
