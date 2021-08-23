using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer2
{
    public class Medico : Persona
    {
        public int Matricula { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public DatoContacto DatoContacto { get; set; }

        public Medico(): base(){}
        public Medico(int Id, string Nombre, string Apellido, int Matricula, List<Paciente> Pacientes, DatoContacto DatoContacto) : base(Id, Nombre, Apellido)
        {
            this.Matricula = Matricula;
            this.Pacientes = Pacientes;
            this.DatoContacto = DatoContacto;

        }


    }
}
