using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPracticaPolimorfismo.Transportes
{
    public class Auto:Vehiculo
    {
        public Auto(float maxFuel, int maxNroDePasajeros, float velocidad, string modelo):base(maxFuel, maxNroDePasajeros, velocidad)
        {
            Modelo = modelo;
        }

        public string Modelo { get; set; }

        public override string acelerar()
        {
            return "El auto acelera";
        }

        public override string desacelerar()
        {
            return "El auto desacelera";
        }

        public string doblarAlzq()
        {
            return "El auto dobla a la izquierda";
        }
    }
}
