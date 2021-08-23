using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enfermero:Persona
    {
        public string Cuil { get; set; }
        public Enfermero(): base() { }
        public Enfermero(string nombre, string apellido, DateTime fechaNac, string cuild):base(nombre, apellido, fechaNac)
        {
            Cuil = Cuil;
        }
    }
}
