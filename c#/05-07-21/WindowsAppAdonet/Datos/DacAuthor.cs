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
    public static class DacAuthor
    {
        public static List<Author> Select_TraerTodo()
        {
            // 2-crear una variable del tipo cadena para especificar la consulta de sql
            string consultaSQL = "SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]";

            // 3-preparar el SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            // 4-declarar un reader

            SqlDataReader reader;


            // 6-invocar ExecuteReader() del SqlCommand
            reader = command.ExecuteReader();

            // 7-recorrer los datos
            List<Author> authors = new List<Author>();
            while (reader.Read())
            {
                authors.Add(
                   new Author()
                   {
                       Au_id = reader[0].ToString(),
                       Au_lname = reader["au_lname"].ToString(),
                       Au_fname = reader["au_fname"].ToString(),
                       Address = reader["address"].ToString(),
                       City = reader["city"].ToString(),
                       State = reader["state"].ToString(),
                       Phone = reader["phone"].ToString(),
                       Zip = reader["zip"].ToString(),
                       Contract = (bool)reader["contract"]
                   }
                    );
            }
            //Cerrar reader
            reader.Close();
            //Cerrar conexión
            AdminDB.conectarDB().Close(); //IMPORTANTE SIEMPRE CERRAR - OJO!!!

            return authors;

        }

        public static List<Author> Select_PorCiudad(string city)
        {
            //2 crear una variable del tipo cadena para especificar la consulta de SQL
            string consultaSQL = "SELECT  au_id, au_lname, au_fname, phone, address, city, state, zip , contract FROM  dbo.authors WHERE city=@city";//agregar el where

            //3 preparar el SqlCommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //*****declarar los parametros de SQL -- Es cadena también indicar longitud (size)*/
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;


            //4 declarar un reader
            SqlDataReader reader;

            //6 Invocar ExecuteReader() del SqlCommand
            reader = command.ExecuteReader();

            //7 recorrer los datos
            List<Author> authors = new List<Author>();
            while (reader.Read())
            {
                authors.Add(
                   new Author()
                   {
                       Au_id = reader[0].ToString(),
                       Au_lname = reader["au_lname"].ToString(),
                       Au_fname = reader["au_fname"].ToString(),
                       Address = reader["address"].ToString(),
                       City = reader["city"].ToString(),
                       State = reader["state"].ToString(),
                       Phone = reader["phone"].ToString(),
                       Zip = reader["zip"].ToString(),
                       Contract = (bool)reader["contract"]
                   }
                );
            }
            //Cerrar reader
            reader.Close();
            //Cerrar conexión
            AdminDB.conectarDB().Close(); //IMPORTANTE SIEMPRE CERRAR - OJO!!!

            return authors;

        }

        #region operaciones de modificacion

        public static int Insert(Author author)
        {
            //1 CONSULTA SQL - INSERT INTO
            string consultaSQL = "INSERT INTO dbo.authors (au_id, au_lname, au_fname, phone, address, city, state, zip, contract) " +
                "VALUES (@au_id, @au_lname, @au_fname, @phone, @address, @city, @state, @zip, @contract)";
            //2 CREAR sqlcommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //3 DECLARAR LOS PARAMETROS Y ASIGNAR VALORES
            //SE INSERTA EL ID POR QUE NO ES AUTONUMERICO
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_id;
            command.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_lname;
            command.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_fname;
            command.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            command.Parameters.Add("@state", SqlDbType.VarChar, 2).Value = author.State;
            command.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = author.Zip;
            command.Parameters.Add("@contract", SqlDbType.Bit).Value = author.Contract;

            //4 EJECUTAR EL INSERT

            int filasAfectadas = command.ExecuteNonQuery();

            //CERRAR CONEXION
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

        public static int Update(Author author)
        {
            //1 CONSULTA SQL - UPDATE SET
            string consultaSQL = "UPDATE dbo.authors SET au_lname = @au_lname, au_fname = @au_fname, phone = @phone, address = @address, city = @city, state = @state, zip = @zip, contract = @contract WHERE au_id = @au_id";
            //2 CREAR sqlcommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //3 DECLARAR LOS PARAMETROS Y ASIGNAR VALORES
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_id;
            command.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_lname;
            command.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_fname;
            command.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            command.Parameters.Add("@state", SqlDbType.VarChar, 2).Value = author.State;
            command.Parameters.Add("@zip", SqlDbType.VarChar, 5).Value = author.Zip;
            command.Parameters.Add("@contract", SqlDbType.Bit).Value = author.Contract;

            //4 EJECUTAR EL UPDATE

            int filasAfectadas = command.ExecuteNonQuery();

            //CERRAR CONEXION
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

        public static int Delete(string au_id)
        {
            //1 CONSULTA SQL - UPDATE
            string consultaSQL = "DELETE FROM  dbo.authors WHERE au_id= @au_id";
            //2 crear sqlcommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //3  declarar los parametros y asignar valores
            //Se inserta el ID porque no es autonumerico
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = au_id;

            //4 ejecutar el insert

            int filasAfectadas = command.ExecuteNonQuery();

            //cerrar conexión
            AdminDB.conectarDB().Close();

            return filasAfectadas;

        }
        #endregion

        #region MODELO DESCONECTADO

        public static DataTable Select_TraerTodosDS()
        {
            string consultaSQL = "SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors]";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarDB());

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "authors");

            return ds.Tables["authors"];
        }

        public static DataTable Select_TraerPorId(string au_id)
        {
            string consultaSQL = "SELECT [au_id] ,[au_lname], [au_fname], [phone], [address], [city], [state], [zip],[contract] FROM [dbo].[authors] WHERE au_id=@au_id";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = au_id;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "authors");

            return ds.Tables["authors"];
        }

        #endregion
    }
}
