using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.InstrumentosMusicales
{
    public class Piano : InstrumentoMusical
    {
        #region constructor

        public Piano()
        {
            Nombre = "Piano";
        }

        public Piano(string nombre) : base(nombre) { }

        public string Nombre { get; private set; }

        #endregion

        public override string Afinar()
        {
            return Nombre;
        }
    }
}
