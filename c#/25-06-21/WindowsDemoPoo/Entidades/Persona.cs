using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        #region constructores 

        public Persona() { } //constructor predeterminado

        public Persona(string Nombre, string Apellido, DateTime FechaNacimiento) //Constructor con parametros
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaNacimiento = FechaNacimiento;
        }

        #endregion
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
