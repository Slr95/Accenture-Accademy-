using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer2
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona() { }

        public Persona(int Id, string Nombre, string Apellido)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

    }
}
