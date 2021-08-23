using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Transportes
{
    public abstract class Vehiculo
    {
        public Vehiculo(float MaxFuel, int MaxNroDePasajeros, float Velocidad) {

            this.MaxFuel = MaxFuel;
            this.MaxNroDePasajeros = MaxNroDePasajeros;
            this.Velocidad = Velocidad;
        }

        public float MaxFuel { get; set; }
        public int MaxNroDePasajeros { get; set; }
        public float Velocidad { get; set; }

        public abstract string acelerar();
        public abstract string desacelerar();
    }
}
