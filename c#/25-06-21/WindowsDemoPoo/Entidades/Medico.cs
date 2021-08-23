using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medico:Persona
    {

        public int Matricula { get; set; }

        public Medico() :base() { }
        public Medico(string nombre, string apellido, DateTime fechaNacimiento, int mat):base(nombre, apellido, fechaNacimiento)
        {
            Matricula = mat;
        }
    }
}
