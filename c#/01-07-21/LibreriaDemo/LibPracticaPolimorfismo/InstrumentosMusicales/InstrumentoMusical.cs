using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.InstrumentosMusicales
{
    public abstract class InstrumentoMusical
    {
        #region constructor

        public InstrumentoMusical(string nombre)
        {

            Nombre = nombre;
        }

        public string Nombre { get; set; }

        #endregion

        public abstract string Afinar();
    }
}
