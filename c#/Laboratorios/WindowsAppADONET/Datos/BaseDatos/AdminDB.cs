using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Agregar

namespace Datos.BaseDatos
{

    //AdminDB.conectarDB()
    public static class AdminDB
    {
        internal static SqlConnection conectarDB()
        {
            string cadena = Properties.Settings.Default.KeyBD;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            return connection;
        }
        internal static SqlConnection conectarDBNorth()
        {
            string cadena = Properties.Settings.Default.NothDB;
            SqlConnection connection = new SqlConnection(cadena);
            connection.Open();
            return connection;
        }
    }
}
