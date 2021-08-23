using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{   
   public class Profesor : Persona
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
    }
}
