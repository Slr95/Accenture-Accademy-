using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPracticaPolimorfismo;

namespace LibPracticaPolimorfismo.InstrumentosMusicales
{
    public class Violin:InstrumentoMusical
    {
        #region constructor

        public Violin()
        {
            Nombre = "Violin";
        }

        public Violin(string nombre): base(nombre) { }

        public string Nombre { get; private set; }

        #endregion
        public override string Afinar()
        {
            return Nombre;
        }
    }

       
}
