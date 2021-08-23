using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Publicador:Persona
    {
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public long Contacto { get; set; }
        public string Pais { get; set; }
        public Publicador() { }
        public Publicador(string n, string a, string d, string c, long co, string p) : base(n, a)
        {
            this.Nombre = n;
            this.Apellido = a;
            this.Domicilio = d;
            this.Ciudad = c;
            this.Contacto = co;
            this.Pais = p;
        }
    }
}
