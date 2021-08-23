using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Transportes
{
    public class Avion: Vehiculo
    {
        public Avion(float maxFuel, int maxNroDePasajeros, float velocidad, float maxAltitud, int nroMotores): base(maxFull, maxNroDePasajeros, velocidad)
        {
            MaxAltitud = maxAltitud;
            NroMotores = nroMotores;
        }

        public float MaxAltitud { get; set; }
        public int NroMotores { get; set; }

        public override string acelerar()
        {
            return "El avion acelera";
        }

        public override string desacelerar()
        {
            return "El avion desacelera";
        }

        public string descender()
        {
            return "El avion desciende";
        }
    }
}
