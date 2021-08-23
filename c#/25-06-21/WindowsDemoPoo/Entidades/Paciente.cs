using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {

        #region

        public Paciente():base() { }

        public Paciente(string nombre, string apellido, DateTime fechaNacimiento, int nroHistoriaClinica) :base(nombre, apellido, fechaNacimiento)
        {
            NroHistoriaClinica = nroHistoriaClinica;
        }

        #endregion

        public int NroHistoriaClinica { get; set; }

    
    }
}
