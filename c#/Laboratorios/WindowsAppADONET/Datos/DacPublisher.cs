using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos;
using Datos.Models;

namespace Datos
{
    public static class DacPublisher
    {
        public static List<Publisher> Select_Traertodo()
        {
            string consultaSQL = "SELECT pub_id ,pub_name ,city ,state ,country FROM dbo.publishers";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Publisher> publisher = new List<Publisher>();
            while (reader.Read())
            {
                publisher.Add(
                new Publisher()
                {
                    Pub_id = reader[0].ToString(),
                    Pub_name = reader["pub_name"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Country = reader["country"].ToString()
                }
                    );
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return publisher;
        }
        public static List<Publisher> Select_CiudadSinDuplicados()
        {
            string consultaSQL = "SELECT distinct city FROM dbo.publishers";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Publisher> ciudad = new List<Publisher>();
            while (reader.Read())
            {
                ciudad.Add(
                    new Publisher()
                    {
                    City= reader["city"].ToString()
                }
                );
            }
            reader.Close();
            AdminDB.conectarDB().Close();
            return ciudad;
        }
        public static List<Publisher> Select_PorCiudad(string city)
        {
            string consultaSQL = "SELECT pub_id ,pub_name ,city ,state ,country FROM dbo.publishers where city=@city";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());
            //***********Declarar los parametros de SQL -- si es cadena se indica la longitud(size)*/
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Publisher> publisher = new List<Publisher>();
            while (reader.Read())
            {
                publisher.Add(
                new Publisher()
                {
                    Pub_id = reader[0].ToString(),
                    Pub_name = reader["pub_name"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Country = reader["country"].ToString()
                }
                    );
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return publisher;
        }
        public static List<Publisher> Select_PorCiudadPais(string city, string country)
        {
            string consultaSQL = "SELECT pub_id ,pub_name ,city ,state ,country FROM dbo.publishers where country=@country and city=@city";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());
            //***********Declarar los parametros de SQL -- si es cadena se indica la longitud(size)*/
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            command.Parameters.Add("@country", SqlDbType.VarChar, 20).Value = country;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Publisher> publisher = new List<Publisher>();
            while (reader.Read())
            {
                publisher.Add(
                new Publisher()
                {
                    Pub_id = reader[0].ToString(),
                    Pub_name = reader["pub_name"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Country = reader["country"].ToString()
                }
                    );
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return publisher;
        }
    }
}
