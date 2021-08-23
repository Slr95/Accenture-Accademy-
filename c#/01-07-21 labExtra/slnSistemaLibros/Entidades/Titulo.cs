using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Titulo
    {
        public string NombreAutor { get; set; }
        public string TituloLibro { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string Notas { get; set; }
        public Titulo() { }
        public Titulo(string n, string t, string c, double p, string s)
        {
            this.NombreAutor = n;
            this.TituloLibro = t;
            this.Categoria = c;
            this.Precio = p;
            this.Notas = n;
        }
    }
}
