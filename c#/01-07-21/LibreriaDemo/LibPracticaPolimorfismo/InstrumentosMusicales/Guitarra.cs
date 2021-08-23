using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.InstrumentosMusicales
{
    public class Guitarra : InstrumentoMusical
    {
        #region constructor

        public Guitarra()
        {
            Nombre = "Guitarra";
        }

        public Guitarra(string nombre): base(nombre) { }

        public string Nombre { get; private set; }

        #endregion

        public override string Afinar()
        {
            return Nombre;
        }
    }
}
