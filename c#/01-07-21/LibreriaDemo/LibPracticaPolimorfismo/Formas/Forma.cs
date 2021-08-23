using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Formas
{
    public abstract class Forma
    {
        public float Area { get; set; }
        public Forma(float area)
        {
            Area = area;
        }
        public abstract float CalcularArea();
    }
}
