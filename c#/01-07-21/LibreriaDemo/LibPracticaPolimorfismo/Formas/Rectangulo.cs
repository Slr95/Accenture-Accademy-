using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Formas
{
    public class Rectangulo:Forma
    {
        public Rectangulo(float Area) : base(Area)
        {

        }

        public override float CalcularArea()
        {
            return Area;
        }
    }
}
