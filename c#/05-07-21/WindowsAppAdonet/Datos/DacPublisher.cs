using Datos.BaseDatos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacPublisher
    {


        public static List<Publisher> SelectTraerTodos()
        {

            string consultaSQL = "SELECT [pub_id], [pub_name], [city], [state], [country] FROM [dbo].[publishers]";

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();
            while (reader.Read())
            {
                publishers.Add(
                   new Publisher()
                   {
                       Pub_id = reader[0].ToString(),
                       Pub_name = reader["pub_name"].ToString(),
                       City = reader["city"].ToString(),
                       State = reader["state"].ToString(),
                       Country = reader["country"].ToString(),
                   }
                    );
            }
            //Cerrar reader
            reader.Close();
            //Cerrar conexión
            AdminDB.conectarDB().Close(); //IMPORTANTE SIEMPRE CERRAR - OJO!!!

            return publishers;
        }

        public static List<Publisher> Select_CiudadSinDuplicados()
        {
            string consultaSQL = "SELECT DISTINCT [city] FROM [dbo].[publishers]";

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Publisher> publishers = new List<Publisher>();
            while (reader.Read())
            {
                publishers.Add(
                   new Publisher()
                   {
                       City = reader["city"].ToString(),

                   }
                    );
            }
            reader.Close();
            AdminDB.conectarDB().Close(); 

            return publishers;
        }
    }
        
        
}
