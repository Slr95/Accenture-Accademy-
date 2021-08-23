using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        public string Titulo { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Empleado() { }

        public Empleado(string n, string a, string t, DateTime f):base(n, a)
        {
            this.Nombre = n;
            this.Apellido = a;
            this.Titulo = t;
            this.FechaIngreso = f;
        }
    }
}
