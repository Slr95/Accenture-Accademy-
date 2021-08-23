using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ejer2;

namespace Datos
{
    public static class AdminMedico
    {

        public static int Insertar(Medico medico)
        {
            //todo FALTA CODIGO DE ACCESO A LA BASE DE DATOS
            return 0;
        }

        public static List<Medico> listar()
        {
            //todo FALTA CODIGO DE ACCESO A LA BASE DE DATOS


            List<Medico> lista = new List<Medico>()
            {
                new Medico(){ Matricula=1212},
                new Medico(){Matricula=999}
            };

            return lista;
        }

    }
}
