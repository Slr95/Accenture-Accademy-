using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDemo.Polimorfismo
{
    //clase abstracta solo para herencia
    public abstract class Archivo
    {
        //metodo abstracto para polimorfismo - es obligatorio ser implementado en la clase derivada
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">se espera una cadena con la ruta</param>
        /// <param name="msj">se espera una cadena con el mensaje</param>
        public abstract void registrar(string path, string msj);
    }
}
