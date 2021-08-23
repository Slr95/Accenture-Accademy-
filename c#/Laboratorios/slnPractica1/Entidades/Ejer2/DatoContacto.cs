using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer2
{
    public class DatoContacto
    {
        private string v1;
        private int v2;
        private int v3;

        public DatoContacto(string v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }

        public Paciente Paciente { get; set; }
        public Clinica Clinica { get; set; }
        public Medico Medico { get; set; }
    }
}
