using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDemo.Polimorfismo
{
    public class Profesor: Persona
    {
        public string Titulo { get; set; }

        public override string imprimir()
        {
            return base.imprimir() + " Titulo: " + Titulo;
        }
    }
}
