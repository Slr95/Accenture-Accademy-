using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosBL
{
    public class AdminSeguridad
    {
        /// <summary>
        /// validar las credenciales del usuario
        /// </summary>
        /// <param name="usuario">se espera el nombre del usuario (cadena) </param>
        /// <param name="password">se espera una password maximo 4 digitos (cadena) </param>
        /// <returns>retorna true si el usuario existe en la db si no false</returns>
        public bool autenticar(string usuario, string password)
        {
            if (usuario=="pepe" && password=="1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
