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
    public static class DacProducto
    {
        public static List<Product> Select_Traertodo()
        {
            string consultaSQL = "SELECT ProductID ,ProductName ,SupplierID ,CategoryID ,QuantityPerUnit ,UnitPrice ,UnitsInStock ,UnitsOnOrder ,ReorderLevel ,Discontinued FROM dbo.Products";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDBNorth());
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Product> product = new List<Product>();
            while (reader.Read())
            {
                product.Add(
                    new Product()
                    {
                        ProductID = (int)reader[0],
                        ProductName = reader["ProductName"].ToString(),
                        SupplierID = (int)reader["SupplierID"],
                        CategoryID = (int)reader["CategoryID"],
                        QuantityPerUnit = reader["QuantityPerUnit"].ToString(),
                        UnitPrice = (Decimal)reader["UnitPrice"],
                        UnitsInStock = (Int16)reader["UnitsInStock"],
                        UnitsOnOrder = (Int16)reader["UnitsOnOrder"],
                        ReorderLevel = (Int16)reader["ReorderLevel"],
                        Discontinued = (bool)reader["Discontinued"]
                    }
                    );
            }
            reader.Close();
            AdminDB.conectarDBNorth().Close();
            return product;
        }
        public static List<Product> Select_Traertodo(int CategoryID)
        {
            string consultaSQL = "SELECT ProductID ,ProductName ,SupplierID ,CategoryID ,QuantityPerUnit ,UnitPrice ,UnitsInStock ,UnitsOnOrder ,ReorderLevel ,Discontinued FROM dbo.Products where CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(consultaSQL, AdminDB.conectarDBNorth());
            command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = CategoryID;
            SqlDataReader reader;
            reader = command.ExecuteReader();
            List<Product> product = new List<Product>();
            while (reader.Read())
            {
                product.Add(
                    new Product()
                    {
                        ProductID = (int)reader[0],
                        ProductName = reader["ProductName"].ToString(),
                        SupplierID = (int)reader["SupplierID"],
                        CategoryID = (int)reader["CategoryID"],
                        QuantityPerUnit = reader["QuantityPerUnit"].ToString(),
                        UnitPrice = (Decimal)reader["UnitPrice"],
                        UnitsInStock = (Int16)reader["UnitsInStock"],
                        UnitsOnOrder = (Int16)reader["UnitsOnOrder"],
                        ReorderLevel = (Int16)reader["ReorderLevel"],
                        Discontinued = (bool)reader["Discontinued"]
                    }
                    );
            }
            reader.Close();
            AdminDB.conectarDBNorth().Close();
            return product;
        }
    }
}