using Datos.BaseDeDatos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacProfesor
    {
        //Listar() retorna una lista de profesor
        public static List<Profesor> listar()
        {
            string consultaSQL = "SELECT[Id],[Nombre],[Apellido],[DNI],[Titulo] FROM [dbo].[Profesor]";

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Profesor> profesors = new List<Profesor>();
            while (reader.Read())
            {
                profesors.Add(
                    new Profesor()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        DNI = reader["DNI"].ToString(),
                        Titulo = reader["Titulo"].ToString()
                    }

                    );
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return profesors;
        }

        //TraerporId(id) retorna un DataTable
        public static DataTable traerPorIdDS(int idProfesor)
        {
            string consultaSQL = "SELECT[Id],[Nombre],[Apellido],[DNI],[Titulo] FROM[dbo].[Profesor] WHERE Id=@Id";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idProfesor;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Profesor");

            return ds.Tables["Profesor"];
        }

        //INSERTAR(Profesor) retorna Filasafectadas
        public static int insert(Profesor profesor)
        {
            string consultaSql = "INSERT INTO [dbo].[Profesor] ([Nombre] ,[Apellido] ,[DNI],[Titulo]) VALUES (@Nombre, @Apellido, @DNI, @Titulo)";
            SqlCommand command = new SqlCommand(consultaSql, AdminDB.conectarDB());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 11).Value = profesor.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 40).Value = profesor.Apellido;
            command.Parameters.Add("@DNI", SqlDbType.VarChar, 20).Value = profesor.DNI;
            command.Parameters.Add("@Titulo", SqlDbType.Char, 50).Value = profesor.Titulo;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

        //OPERACION UPDATE
        public static int update(Profesor profesor)
        {
            string consultaSql = " UPDATE[dbo].[Profesor] SET[Nombre] = @Nombre, [Apellido] = @Apellido, [DNI] = @DNI, [Titulo] = @Titulo WHERE Id = @Id";

            SqlCommand command = new SqlCommand(consultaSql, AdminDB.conectarDB());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 11).Value = profesor.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 40).Value = profesor.Apellido;
            command.Parameters.Add("@DNI", SqlDbType.VarChar, 20).Value = profesor.DNI;
            command.Parameters.Add("@Titulo", SqlDbType.Char, 50).Value = profesor.Titulo;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = profesor.Id;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

        //OPERACION DELETE
        public static int delete(int idProfesor)
        {
            string consultaSql = "DELETE FROM [dbo].[Profesor] WHERE Id = @Id";
            SqlCommand command = new SqlCommand(consultaSql, AdminDB.conectarDB());

            command.Parameters.Add("@Id", SqlDbType.Int).Value = idProfesor;

            int filasAfectadas = command.ExecuteNonQuery();

            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

    }


}

