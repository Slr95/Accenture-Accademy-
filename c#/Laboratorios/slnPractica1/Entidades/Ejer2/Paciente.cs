using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer2
{
    public class Paciente:Persona
    {
        internal int id;
        private int v;
        private object p;

        public int NroHistoriaClinica { get; set; }
        public Medico Medico { get; set; }

        public DatoContacto DatoContacto { get; set; }

        public Paciente(int v, string v1) : base() { }
        public Paciente(int Id, string Nombre, string Apellido, int Matricula, int NroHistoriaClinica, DatoContacto DatoContacto) : base(Id, Nombre, Apellido)
        {
            this.NroHistoriaClinica = NroHistoriaClinica;
            this.DatoContacto = DatoContacto;

        }

        public Paciente(int Id, string Nombre, string Apellido, DatoContacto datoContacto, int v, object p) : base(Id, Nombre, Apellido)
        {
            DatoContacto = datoContacto;
            this.v = v;
            this.p = p;
        }
    }
}
