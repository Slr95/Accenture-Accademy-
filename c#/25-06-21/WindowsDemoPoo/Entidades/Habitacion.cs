using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Habitacion
    {
        public Habitacion() { } //constructor predeterminado

        public Habitacion(string Estado, int numero) //constructor con parametro
        {
            this.Estado = Estado;
            Numero = numero;
        }
        public int Numero { get; set; }

        public string Estado { get; set; }
    }
}
