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
    public static class DacVendedor
    {
        //Listar() 
        public static List<Vendedor> listar()
        {
            string consultaSQL = "SELECT [Id], [Nombre], [Apellido], [DNI], [Comision] FROM [dbo].[Vendedor]";

            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDB());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Vendedor> vendedores = new List<Vendedor>();
            while (reader.Read())
            {
                vendedores.Add(
                    new Vendedor()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        DNI = reader["DNI"].ToString(),
                        Comision = Convert.ToDecimal(reader["Comision"])
                    }

                    );
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return vendedores;
        }

        //TraerPorId(id)

        public static DataTable traerPorIdDS(int idVendedor)
        {
            string consultaSQL = "SELECT [Id], [Nombre], [Apellido], [DNI], [Comision] FROM [dbo].[Vendedor] WHERE Id=@Id";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idVendedor;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Vendedor");

            return ds.Tables["Vendedor"];
        }

        //Insertar(Vendedor)

        public static int insert(Vendedor vendedor)
        {
            string consultaSql = "INSERT INTO [dbo].[Vendedor] ([Nombre], [Apellido], [DNI], [Comision]) VALUES (@Nombre, @Apellido, @DNI, @Comision)";
            SqlCommand command = new SqlCommand(consultaSql, AdminDB.conectarDB());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            command.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = vendedor.DNI;
            command.Parameters.Add("@Comision", SqlDbType.Decimal, 18).Value = vendedor.Comision;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

        //Traer vendedores por comision

        public static DataTable traerPorComision(int comision)
        {
            string consultaSQL = "SELECT [Id], [Nombre], [Apellido], [DNI], [Comision] FROM [dbo].[Vendedor] WHERE Comision=@Comision";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consultaSQL, AdminDB.conectarDB());

            dataAdapter.SelectCommand.Parameters.Add("@Comision", SqlDbType.Decimal).Value = comision;

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "Vendedor");

            return ds.Tables["Vendedor"];
        }

        //Modificar

        public static int update(Vendedor vendedor)
        {
            string consultaSql = " UPDATE[dbo].[Vendedor] SET[Nombre] = @Nombre, [Apellido] = @Apellido, [DNI] = @DNI, [Comision] = @Comision WHERE Id = @Id";

            SqlCommand command = new SqlCommand(consultaSql, AdminDB.conectarDB());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
            command.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = vendedor.DNI;
            command.Parameters.Add("@Comision", SqlDbType.Decimal, 18).Value = vendedor.Comision;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = vendedor.Id;

            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }

        //Eliminar

        public static int delete(int idVendedor)
        {
            string consultaSql = "DELETE FROM [dbo].[Vendedor] WHERE Id = @Id";
            SqlCommand command = new SqlCommand(consultaSql, AdminDB.conectarDB());

            command.Parameters.Add("@Id", SqlDbType.Int).Value = idVendedor;

            int filasAfectadas = command.ExecuteNonQuery();

            AdminDB.conectarDB().Close();

            return filasAfectadas;
        }
    }
}
