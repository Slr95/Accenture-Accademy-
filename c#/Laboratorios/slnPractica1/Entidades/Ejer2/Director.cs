using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejer2
{
    public class Director:Medico
    {
        public Clinica Clinica { get; set; }

        public Director() : base() { }
        public Director(int Id, string Nombre, string Apellido, int Matricula, List<Paciente> Pacientes, DatoContacto DatoContacto, Clinica Clinica) : base(Id, Nombre, Apellido, Matricula, Pacientes,DatoContacto)
        {
            this.Clinica = Clinica;

        }

    }
}
