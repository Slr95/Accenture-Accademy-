using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor:Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public Autor() { }
        public Autor(string n, string a, DateTime f, string d, string c, string p) : base(n, a)
        {
            this.Nombre = n;
            this.Apellido = a;
            this.FechaNacimiento = f;
            this.Domicilio = d;
            this.Ciudad = c;
            this.Pais = p;
        }
    }
}
