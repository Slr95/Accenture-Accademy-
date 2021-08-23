using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Formas
{
    public class Cuadrado : Forma
    {
        public Cuadrado(float Area) : base(Area)
        {

        }

        public override float CalcularArea()
        {
            return Area;
        }
    }
}
