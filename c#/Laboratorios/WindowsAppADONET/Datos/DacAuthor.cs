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
    public static class DacAuthor//Data acces Author
    {
        public static List<Author> Select_Traertodo()
        {
            //2-Cadena para especificar la consulta de SQL
            string consultaSQL = "SELECT au_id, au_lname ,au_fname ,phone ,address ,city ,state ,zip ,contract FROM dbo.authors";
            //3- preparar el SqlCommand
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //4-Declarar un reader
            SqlDataReader reader;
            //5- Abrir conexion
            //connection.Open(); /se toma en la linea 18
            //6-Invocar ExecuteReader() del SqlCommand
            reader = command.ExecuteReader();
            //7-Recorrer datos
            List<Author> authors = new List<Author>();
            while (reader.Read())//se resuelve con una lista ya que biblioteca no tiene interfaz grafica
            {
                authors.Add(
                new Author() {
                    Au_id = reader[0].ToString(),
                    Au_lname = reader["au_lname"].ToString(),
                    Au_fname = reader["au_fname"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Address = reader["address"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Zip = reader["zip"].ToString(),
                    Contract = (bool)reader["contract"] }
                    );
            }
            //8-Cerrar Reader
            reader.Close();
            //9-Cerrar coneccion
            AdminDB.conectarDB().Close();//IMPORTANTE CIEMPRE CERRAR!!

            return authors;
        }
        public static List<Author> Select_TraerPorState(string state)
        {
            string consultaSQL = "SELECT au_id, au_lname ,au_fname ,phone ,address ,city ,state ,zip ,contract FROM dbo.authors where state=@state";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Author> authors = new List<Author>();
            while (reader.Read())
            {
                authors.Add(
                new Author()
                {
                    Au_id = reader[0].ToString(),
                    Au_lname = reader["au_lname"].ToString(),
                    Au_fname = reader["au_fname"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Address = reader["address"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Zip = reader["zip"].ToString(),
                    Contract = (bool)reader["contract"]
                }
                    );
            }
            
            reader.Close();
            AdminDB.conectarDB().Close();

            return authors;
        }
        #region Operaciones de modificacion

        public static int insert(Author author)
        {
            //1 consulta sql - insert into
            string consultaSQL = "INSERT INTO  dbo.authors ( au_id, au_lname, au_fname, phone, address, city, state, zip ,contract) VALUES  ( @au_id ,@au_lname ,@au_fname ,@phone ,@address, @city ,@state ,@zip ,@contract)";

            //Crear SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //declara los parametros y asigna valores
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_id;
            command.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_lname;
            command.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_fname;
            command.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = author.State;
            command.Parameters.Add("@zip", SqlDbType.Char, 5).Value = author.Zip;
            command.Parameters.Add("@contract", SqlDbType.Bit).Value = author.Contract;

            //ejecutar insert
            int filasafectadas = command.ExecuteNonQuery();

            //cerrar conexion
            AdminDB.conectarDB().Close();

            return filasafectadas;
        }
        public static int update(Author author)
        {
            //1 consulta sql - Update
            string consultaSQL = "UPDATE dbo.authors SET au_lname = @au_lname, au_fname = @au_fname, phone = @phone, address = @address, city = @city, state = @state, zip = @zip, contract = @contract WHERE au_id = @au_id";

            //Crear SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //declara los parametros y asigna valores
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = author.Au_id;
            command.Parameters.Add("@au_lname", SqlDbType.VarChar, 40).Value = author.Au_lname;
            command.Parameters.Add("@au_fname", SqlDbType.VarChar, 20).Value = author.Au_fname;
            command.Parameters.Add("@phone", SqlDbType.Char, 12).Value = author.Phone;
            command.Parameters.Add("@address", SqlDbType.VarChar, 40).Value = author.Address;
            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = author.City;
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = author.State;
            command.Parameters.Add("@zip", SqlDbType.Char, 5).Value = author.Zip;
            command.Parameters.Add("@contract", SqlDbType.Bit).Value = author.Contract;

            //ejecutar insert
            int filasafectadas = command.ExecuteNonQuery();

            //cerrar conexion
            AdminDB.conectarDB().Close();

            return filasafectadas;
        }
        public static int delete(string au_id)
        {
            //1 consulta sql - Delete
            string consultaSQL = "DELETE FROM  dbo.authors WHERE au_id= @au_id";

            //Crear SqlCommand

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            //declara los parametros y asigna valores
            command.Parameters.Add("@au_id", SqlDbType.VarChar, 11).Value = au_id;


            //ejecutar insert
            int filasafectadas = command.ExecuteNonQuery();

            //cerrar conexion
            AdminDB.conectarDB().Close();

            return filasafectadas;
        }
        #endregion
    }
}
