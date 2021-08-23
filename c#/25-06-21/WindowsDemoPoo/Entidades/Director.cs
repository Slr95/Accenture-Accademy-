using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Director:Medico
    { 

        public string Titulo { get; set; }

        public Director() : base() { }
        public Director(string nombre, string apellido, DateTime fechaNac, int mat, string titulo):base(nombre, apellido, fechaNac, mat)
        {
            Titulo = titulo;
        }
    }
}
