using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public string Tienda { get; set; }
        public int NumeroOrden { get; set; }

        public DateTime FechaCompra { get; set; }
        public int Cantidad { get; set; }
        public string Titulo { get; set; }

        public Venta() { }
        public Venta(string t, int n, DateTime f, int c, string ti)
        {
            this.Tienda = t;
            this.NumeroOrden = n;
            this.FechaCompra = f;
            this.Cantidad = c;
            this.Titulo = ti;
        }
    }
}
