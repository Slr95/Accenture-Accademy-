using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer2
{
    public class Clinica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Director Director { get; set; }
        public DatoContacto DatoContacto { get; set; }

        public Clinica() { }
        
        public Clinica(int Id, string Nombre, Director Director, DatoContacto DatoContacto)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Director = Director;
            this.DatoContacto = DatoContacto;
        }
    }
}
