using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Formas
{
    public class Circulo : Forma
    {
        public Circulo(float Area) : base(Area)
        {

        }

        public override float CalcularArea()
        {
            return Area;

        }

    }
}