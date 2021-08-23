using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Vendedor:Persona
    {
        private decimal comision;

        public decimal Comision
        {
            get { return comision; }
            set { comision = value; }
        }
    }
}
