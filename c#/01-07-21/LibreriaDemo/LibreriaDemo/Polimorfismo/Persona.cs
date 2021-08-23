﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDemo.Polimorfismo
{
    public abstract class Persona
    {

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public virtual string imprimir()
        {
            return Nombre + ", " + Apellido;
        }
    }
}
