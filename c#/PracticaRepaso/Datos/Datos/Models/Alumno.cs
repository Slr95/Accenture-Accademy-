using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public abstract class Alumno:Persona
    {
        private int nroMatricula;
        public int NroMatricula
        {
            get { return nroMatricula; }
            set { nroMatricula = value; }
        }
    }

    
}
